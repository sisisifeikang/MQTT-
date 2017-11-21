using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MqttLib;
using System.Runtime.Serialization;

namespace MqttClient
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
    public class Message
    {
        public DateTime Datetime;
        public string Topic;
        public string Payload;
        public string Name;
        public string Retained;
        public Message(PublishArrivedArgs e)
        {
            Datetime = DateTime.Now;
            Topic = e.Topic;
            Payload = e.Payload.ToString();
            Name = StaticResources.QosToName(e.QualityOfService);
            Retained = e.Retained ? "是" : "否";
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("时间："+Datetime.ToString()+"\r\n");
            stringBuilder.Append("主题："+Topic.ToString()+"\r\n");
            stringBuilder.Append("消息："+Payload.ToString()+"\r\n");
            stringBuilder.Append("服务质量："+Name+"\r\n");
            stringBuilder.Append("是否保留："+ Retained + "\r\n");
            return stringBuilder.ToString();
        }
    }
}
