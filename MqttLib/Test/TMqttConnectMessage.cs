using Moq;
using System.IO;
using Xunit;
namespace MqttLib.Core.Messages.Test
{
    public class TMqttConnectMessage
    {

        [Fact]
        public void InitMqttConnetMessageTemp()
        {
            MqttConnectMessage mqttConnectMessage = new MqttConnectMessage("test", "sa", "123456", 255, false);

            Assert.Equal("test", mqttConnectMessage.ClientID);
            Assert.Equal("sa", mqttConnectMessage.UserName);
            Assert.Equal("123456", mqttConnectMessage.Password);
            Assert.Equal(255, mqttConnectMessage.KeepAlive);
            Assert.False(mqttConnectMessage.CleanSession);
        }
        [Theory]
        [InlineData("testMyClent", "feikang", "123456", 0, false)]
        [InlineData("sa", "guanqin", "", 1, false)]
        [InlineData("linsipei", "sipei", "123456", 65535, true)]
        [InlineData("chenfuming", "fuming", "123456", 65536, true)]
        [InlineData("", "wangtian", "!!..''", -1, false)]
        [InlineData("!@#$%", " ", "!!..''", 1, false)]
        public void InitMqttConnetMessage(string clientID,string userID,string password,ushort keepAlive,
            bool cleanSession)
        {
            MqttConnectMessage mqttConnectMessage = new MqttConnectMessage(clientID,userID, password, keepAlive, cleanSession);

            Assert.Equal(clientID, mqttConnectMessage.ClientID);
            Assert.Equal(userID, mqttConnectMessage.UserName);
            Assert.Equal(password, mqttConnectMessage.Password);
            Assert.Equal(keepAlive, mqttConnectMessage.KeepAlive);
            Assert.Equal(cleanSession, mqttConnectMessage.CleanSession);

            //获取消息类型
            Assert.Equal(MessageType.CONNECT, mqttConnectMessage.MsgType);
            //用户名位与密码位
            Assert.Equal(userID.Trim().Length>0?true:false,mqttConnectMessage.ContainUsername);
            Assert.Equal(password.Trim().Length>0?true:false,mqttConnectMessage.ContainPassword);
            
        }
        [Theory]
        [InlineData("testMyClent", "feikang", "123456", 0, "testTopic", new byte[] { 1, 2, 3 }, QoS.AtLeastOnce, true, false)]
        [InlineData("guanxige", "guanqin", "", 1, "", new byte[] { 1, 2, 3 }, QoS.BestEfforts, true, false)]
        [InlineData("niub", "sipei", "", 65535, "testTopic", new byte[] { }, QoS.OnceAndOnceOnly, true, true)]
        [InlineData("yyf123123", "fuming", "123456", 125, "testTopic", new byte[] { 1, 2, 3 }, QoS.OnceAndOnceOnly, true, true)]
        [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "wangtian", "!!..''", 126, "testTopic", new byte[] { 1, 2, 3 }, QoS.OnceAndOnceOnly, true, false)]
        public void InitMqttConnetMessage2(string clientID, string username, string password, ushort keepAlive,
          string willTopic, byte[] willPayload,
          QoS willQos, bool willRetained, bool cleanStart)
        {
            MqttConnectMessage mqttConnectMessage = new MqttConnectMessage(clientID, username, password, keepAlive,
                willTopic, willPayload, willQos, willRetained, cleanStart);

            Assert.Equal(clientID, mqttConnectMessage.ClientID);
            Assert.Equal(username, mqttConnectMessage.UserName);
            Assert.Equal(password, mqttConnectMessage.Password);
            Assert.Equal(keepAlive, mqttConnectMessage.KeepAlive);
            Assert.Equal(cleanStart, mqttConnectMessage.CleanSession);

            Assert.Equal(MessageType.CONNECT, mqttConnectMessage.MsgType);
            Assert.Equal(username.Trim().Length > 0 ? true : false, mqttConnectMessage.ContainUsername);
            Assert.Equal(password.Trim().Length > 0 ? true : false, mqttConnectMessage.ContainPassword);

            Assert.Equal(willQos, mqttConnectMessage.QualityOfService);
            Assert.Equal(willRetained, mqttConnectMessage.Retained);
            Assert.Equal(willTopic, mqttConnectMessage.WillTopic);
            Assert.Equal(willPayload, mqttConnectMessage.WillPayload);

        }
    }
}
