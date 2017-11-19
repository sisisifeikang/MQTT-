using MqttLib;
using System;

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

        public bool Connect(string connString, string clientId,bool cleanSession,ushort keepAlive, 
            string username = null, string password = null, 
            IPersistence persistence = null)
        {
            try
            {
                mqtt = MqttClientFactory.CreateClient(connString, clientId, username, password, persistence);
                mqtt.KeepAliveInterval = keepAlive;
                mqtt.Connect(cleanSession);
                mqtt.Connected += Mqtt_Connected;
                mqtt.ConnectionLost += Mqtt_ConnectionLost;
                return true;
            }
            catch(Exception m_ex)
            {
                return false;
            }
        }

        private void Mqtt_ConnectionLost(object sender, EventArgs e)
        {
            //根据心跳包检测到连接断开,需要向UI层抛出信息显示
            Console.WriteLine("Lost");
            System.Threading.Thread thread = new System.Threading.Thread(AutoConnect);
            thread.Start();
        }

        private void Mqtt_Connected(object sender, EventArgs e)
        {
            //需要向UI层抛出信息显示
            Console.WriteLine("OK");
        }

        public void AutoConnect()
        {
            while(!mqtt.IsConnected)
            {
                try
                {
                    mqtt.Connect();
                }
                catch(Exception m_Ex)
                {
                    Console.WriteLine("AutoConnect False");
                }
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds( mqtt.KeepAliveInterval));
            }
        }



    }
}
