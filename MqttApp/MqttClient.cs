using MqttLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MqttClient
{
    class MqttClient
    {
        private MqttClient()
        { }
        private static MqttClient client = null;
        public static MqttClient Instance()
        {
            if (client == null)
                client = new MqttClient();
            return client;
        }


        private IMqtt mqtt;
        internal IMqtt Mqtt
        {
            get { return this.mqtt; }
        }
        public bool cleanSession = false;
        private string willTopic = null;
        private string willMessage = null;
        private QoS willQos = QoS.BestEfforts;
        private bool willRetained = false;
        private bool withWill = false;
        internal bool HaveWill
        {
            get { return this.withWill; }
        }
        public bool autoConnected;
        internal bool AutoConnected
        {
            get { return this.autoConnected; }
            set
            {
                if (mqtt!=null&&!mqtt.IsConnected)
                {
                    System.Threading.Thread thread = new System.Threading.Thread(AutoConnect);
                    thread.IsBackground = true;
                    thread.Start();
                }
                autoConnected = value;
            }
        }
        public List<AutoPublishTask> taskList = new List<AutoPublishTask>();

        public bool SetWill(string topic, string message, string qos, bool retained)
        {
            if (mqtt == null || mqtt.IsConnected == false)
            {
                withWill = true;
                willTopic = topic;
                willMessage = message;
                willQos = StaticResources.NameToQos(qos);
                willRetained = retained;
                return true;
            }
            return false;
        }
        public bool DeleteWill()
        {
            if (mqtt == null || mqtt.IsConnected == false)
            {
                withWill = false;
                return true;
            }
            return false;
        }



        public bool Connect(string connString, string clientId, ushort keepAlive,
            string username = null, string password = null,
            IPersistence persistence = null)
        {
            try
            {
                mqtt = MqttClientFactory.CreateClient(connString, clientId, 
                    username, password, persistence);
                mqtt.KeepAliveInterval = keepAlive;
                if (withWill)
                    mqtt.Connect(willTopic, willQos, 
                        new MqttPayload(willMessage), willRetained, cleanSession);
                else
                    mqtt.Connect(cleanSession);
                mqtt.Connected += Mqtt_Connected;
                mqtt.PublishArrived += Mqtt_PublishArrived;
                mqtt.Published += Mqtt_Published;
                mqtt.Subscribed += Mqtt_Subscribed;
                mqtt.Unsubscribed += Mqtt_Unsubscribed;
                mqtt.ConnectionLost += Mqtt_ConnectionLost;
                return true;
            }
            catch (Exception m_ex)
            {
                return false;
            }
        }

        private void Mqtt_Unsubscribed(object sender, CompleteArgs e)
        {
            StaticResources.messageQueue.Enqueue("时间:" + DateTime.Now.ToString()+
                "取消订阅信息已确认,信息ID：" + e.MessageID);
        }

        private void Mqtt_Subscribed(object sender, CompleteArgs e)
        {

            StaticResources.messageQueue.Enqueue("时间:" + DateTime.Now.ToString()+
                "订阅信息已确认,信息ID：" + e.MessageID);
        }

        private void Mqtt_Published(object sender, CompleteArgs e)
        {
            StaticResources.messageQueue.Enqueue("时间:" + DateTime.Now.ToString()+
                "推送信息已确认,信息ID：" + e.MessageID);
        }

        private bool Mqtt_PublishArrived(object sender, PublishArrivedArgs e)
        {
            Message message = new Message(e);
            StaticResources.messageQueue.Enqueue("时间:" + DateTime.Now.ToString() +
                "收到推送信息：" + message);
            StaticResources.publiishQueue.Enqueue(message);
            return true;
        }

        private void Mqtt_ConnectionLost(object sender, EventArgs e)
        {
            //根据心跳包检测到连接断开,需要向UI层抛出信息显示
            StaticResources.nofifyQueue.Enqueue("断开连接");
            if (AutoConnected)
            {
                System.Threading.Thread thread = new System.Threading.Thread(AutoConnect);
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void Mqtt_Connected(object sender, EventArgs e)
        {
            //需要向UI层抛出信息显示
            StaticResources.nofifyQueue.Enqueue("连接成功");
        }

        public void Close()
        {
            DisConnect();
            mqtt = null;
        }

        public void DisConnect()
        {
            if (mqtt.IsConnected)
                mqtt.Disconnect();
        }

        public void Subscribe(string topic, string name)
        {
            StaticResources.messageQueue.Enqueue("时间:" + DateTime.Now.ToString()+
                "订阅信息，信息ID为：" +
                mqtt.Subscribe(topic, StaticResources.NameToQos(name)));
        }
        public void UnSubscribe(string topic)
        {
            StaticResources.messageQueue.Enqueue("时间:" + DateTime.Now.ToString() 
                + "订阅信息，信息ID为：" +
                mqtt.Unsubscribe(new string[1] { topic}));
        }
        public void Publish(string topic, string message, string name, bool retained)
        {
            Publish(topic, message, StaticResources.NameToQos(name), retained);
        }
        public void Publish(string topic, string message, QoS qoS, bool retained)
        {
            StaticResources.messageQueue.Enqueue("时间:" + DateTime.Now.ToString()+
                "推送信息，信息ID为：" +
                mqtt.Publish(topic, new MqttPayload(message), qoS, retained));
        }



        private void AutoConnect()
        {
            while (mqtt != null && !mqtt.IsConnected)
            {
                try
                {
                    mqtt.Connect();
                }
                catch (Exception m_Ex)
                {
                    Console.WriteLine("AutoConnect False");
                }
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(mqtt.KeepAliveInterval));
            }
        }
    }

    public class AutoPublishTask
    {
        private int timeInterval;
        internal int TimeInterval
        {
            get { return timeInterval; }
        }
        private string topic;
        internal string Topic
        {
            get { return topic; }
        }
        private QoS qoS;
        internal QoS QoS
        {
            get { return qoS; }
        }
        private bool retained;
        internal bool Retained
        {
            get { return Retained; }
        }
        private bool state;
        internal bool IsRun
        {
            get { return state; }
        }
        private string taskName;
        internal string TaskName
        {
            get { return taskName; }
            set { this.taskName = value; }
        }
        private DataTable dataTableMessage;


        private MqttClient mqttClient;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("任务名：" + TaskName+"\r\n");
            stringBuilder.Append("运行状态:" + (state ? "运行中" : "停止")+"\r\n");
            stringBuilder.Append("推送主题:" + topic + "\r\n");
            stringBuilder.Append("服务质量:" + StaticResources.QosToName(qoS));
            stringBuilder.Append("是否保留:" + (retained ? "是" : "否") + "\r\n");
            return stringBuilder.ToString();
        }

        public AutoPublishTask(int time, string t, DataTable dataTable, string qosName, bool retain)
        {
            timeInterval = time;
            topic = t;
            dataTableMessage = dataTable;
            mqttClient = MqttClient.Instance();
            qoS = StaticResources.NameToQos(qosName);
            retained = retain;
            thread = new System.Threading.Thread(AutoPublish);
            thread.IsBackground = true;
        }
        public void Reset(int time, string t, DataTable dataTable, string qosName, bool retain)
        {
            timeInterval = time;
            topic = t;
            dataTableMessage = dataTable;
            mqttClient = MqttClient.Instance();
            qoS = StaticResources.NameToQos(qosName);
            retained = retain;
            thread = new System.Threading.Thread(AutoPublish);
            thread.IsBackground = true;
        }



        private System.Threading.Thread thread;
        public void Run()
        {
            if (state != true)
            {
                state = true;
                thread.Start();
            }
        }
        public void Stop()
        {
            state = false;
        }
        public void AutoPublish()
        {
            while (state)
            {
                if(mqttClient.Mqtt!=null&&mqttClient.Mqtt.IsConnected)
                    mqttClient.Publish(topic, 
                        DataTableToJson.ToJson(dataTableMessage), qoS, retained);
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(timeInterval));
            }
        }


    }
}
