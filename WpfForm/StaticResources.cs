using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MqttLib;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace WpfForm
{
    public class StaticResources
    {
        public static Queue<string> nofifyQueue = new Queue<string>();

        public static Queue<string> messageQueue = new Queue<string>();

        public static Queue<Message> publiishQueue = new Queue<Message>();

       


        private struct QosProperity
        {
            public QoS qoS;
            public string Name;
            public QosProperity(QoS qos,string name)
            {
                qoS = qos;
                Name = name;
            }
        }

        private static List<QosProperity> qosList = new List<QosProperity>()
        {
            new QosProperity(QoS.AtLeastOnce,"至少分发一次"),new QosProperity(QoS.OnceAndOnceOnly,"仅分发一次"),
            new QosProperity(QoS.BestEfforts,"最多分发一次")
        };

        public static QoS NameToQos(string name)
        {
            return qosList.Find(x => x.Name == name).qoS;
        }

        public static string QosToName(QoS qoS)
        {
            return qosList.Find(x => x.qoS == qoS).Name;
        }

        public static List<string> GetNameEnumerable()
        {
            return (from qos in qosList
                           select qos.Name).ToList();                    
        }


    }
    public class Message: INotifyPropertyChanged
    {
        public DateTime datetime;
        public DateTime DateTime
        {
            get{ return this.datetime; }
            set {
                this.datetime = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DateTime"));
            }
        }
        public string topic;
        public string Topic
        {
            get { return this.topic; }
            set
            {
                this.topic = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Topic"));
            }
        }
        public string payload;
        public string Payload
        {
            get { return this.payload; }
            set
            {
                this.payload = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Payload"));
            }
        }
        public string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                this.payload = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }
        public string retained;
        public string Retained
        {
            get { return this.retained; }
            set
            {
                this.payload = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Retained"));
            }
        }
        public Message(PublishArrivedArgs e)
        {
            datetime = DateTime.Now;
            topic = e.Topic;
            payload = e.Payload.ToString();
            name = StaticResources.QosToName(e.QualityOfService);
            retained = e.Retained ? "是" : "否";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("时间："+datetime.ToString()+"\r\n");
            stringBuilder.Append("主题："+topic.ToString()+"\r\n");
            stringBuilder.Append("消息："+payload.ToString()+"\r\n");
            stringBuilder.Append("服务质量："+name+"\r\n");
            stringBuilder.Append("是否保留："+ retained + "\r\n");
            return stringBuilder.ToString();
        }
    }
}
