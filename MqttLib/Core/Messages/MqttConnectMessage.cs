using System;
using System.Collections.Generic;
using System.Text;

namespace MqttLib.Core.Messages
{
    internal class MqttConnectMessage : MqttMessage
    {
        /// <summary>
        /// The version of the MQTT protocol we are using
        /// </summary>
        private const byte VERSION = 3;

        private ushort _keepAlive;
        public ushort KeepAlive
        {
            get { return _keepAlive; }
        }
        private byte[] _clientID;
        public string ClientID
        {
            get { return enc.GetString(_clientID); }
        }

        private bool _containsUsername;
        public bool ContainUsername
        {
            get { return this._containsUsername; }
        }
        private string _username;
        public string UserName
        {
            get { return _username; }
        }
       

        private bool _containsPassword;
        public bool ContainPassword
        {
            get { return _containsPassword; }
        }
        private string _password;
        public string Password
        {
            get { return this._password; }
        }

        private byte _connectFlags;
        public bool CleanSession
        {
            get { return (_connectFlags & 2)==2?true:false; }
        }
        private bool _containsWill;
        public bool ContainsWill
        {
            get { return _containsWill; }
        }
        private string _willTopic;
        public string WillTopic
        {
            get { return _willTopic; }
        }
        private byte[] _willPayload;
        public Byte[] WillPayload
        {
            get { return _willPayload; }
        }

        /// <summary>
        /// Constant description of the protocol
        /// </summary>
        private byte[] protocolDesc = new byte[]
            {
                0,
                6,
                (byte)'M',
                (byte)'Q',
                (byte)'I',
                (byte)'s',
                (byte)'d',
                (byte)'p',
                VERSION
            };

        private void SetConnectVariableHeaderCommon(string clientID, string username, string password, ushort keepAlive)
        {
            _keepAlive = keepAlive;
            _clientID = enc.GetBytes(clientID);
            _containsUsername = !(String.IsNullOrEmpty(username) || username.Trim().Length == 0);
            _username = username;
            _containsPassword = !(String.IsNullOrEmpty(password) || password.Trim().Length == 0);
            _password = password;

            base.variableHeaderLength = (
              protocolDesc.Length + //Length of the protocol description
              3 +                   //Connect Flags + Keep alive
              _clientID.Length +    // Length of the client ID string
              2                     // The length of the length of the clientID
            );

            if (_containsUsername)
                base.variableHeaderLength += _username.Length + 2;

            if (_containsPassword)
                base.variableHeaderLength += _password.Length + 2;
        }

        public MqttConnectMessage(string clientID, string username, string password, ushort keepAlive, 
            bool cleanStart)
            : base(MessageType.CONNECT)
        {
            SetConnectVariableHeaderCommon(clientID, username, password, keepAlive);
            _containsWill = false;
            _connectFlags = (byte)(
                (cleanStart ? 0x02 : 0) |
                (_containsPassword ? 0x40 : 0) |
                (_containsUsername ? 0x80 : 0)
                );
        }

        // TODO: Add a constructor containing WillTopic and WillMessage
        public MqttConnectMessage(
          string clientID, string username, string password, ushort keepAlive,
          string willTopic, byte[] willPayload,
          QoS willQos, bool willRetained, bool cleanStart
        )
            : base(MessageType.CONNECT)
        {
            SetConnectVariableHeaderCommon(clientID, username, password, keepAlive);

            _containsWill = true;
            _willTopic = willTopic;
            _willPayload = willPayload;

            msgQos = willQos;//20171024
            isRetained = willRetained;//20171024

            _connectFlags = (byte)(
              0x04 | // LWT enabled
              (willRetained ? 0x20 : 0) | // LWT is retained?
              (cleanStart ? 0x02 : 0) | // Clean Start
              (_containsPassword ? 0x40 : 0) |
                (_containsUsername ? 0x80 : 0) |
              ((byte)willQos) << 3        // LWT QoS
            );

            base.variableHeaderLength += (
              _willTopic.Length +
              _willPayload.Length +
              4
            );
        }

        protected override void SendPayload(System.IO.Stream str)
        {
            str.Write(protocolDesc, 0, protocolDesc.Length);

            // TODO: Implement Clean Session Flag
            str.WriteByte(_connectFlags);

            // Write the keep alive value
            WriteToStream(str, _keepAlive);

            // Write the payload
            WriteToStream(str, (ushort)_clientID.Length);
            str.Write(_clientID, 0, _clientID.Length);

            if (_containsWill)
            {
                // Write the will topic
                WriteToStream(str, _willTopic);

                // Write the will payload
                WriteToStream(str, (ushort)_willPayload.Length);
                str.Write(_willPayload, 0, _willPayload.Length);
            }

            if (_containsUsername)
            {
                WriteToStream(str, _username);

                if (_containsPassword)
                    WriteToStream(str, _password);
            }

        }

        protected override void ConstructFromStream(System.IO.Stream str)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
