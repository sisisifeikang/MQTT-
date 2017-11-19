using System;
using System.Windows.Forms;
using MqttLib;

namespace MqttClient
{
    public partial class FormConnect : Form
    {
        public FormConnect()
        {
            InitializeComponent();
        }

        private void FormConnect_Load(object sender, EventArgs e)
        {
            SetDefaultValue();
        }

        private void SetDefaultValue()
        {
            radioButtonSession.Checked = true;
            radioButtonConnection.Checked = true;
            textBoxAlive.Text = "120";
            textBoxHostname.Text = "tcp://localhost:1883";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            bool withUser = (textBoxUsername.Text != null && textBoxPassword.Text != null);
            bool result = false;

            ushort keepAliveSecond;
            if(!ushort.TryParse(textBoxAlive.Text, out keepAliveSecond))
            {
                MessageBox.Show("心跳包间隔时间范围为0-255秒");
                return;
            }

            if(withUser)
                result=MqttClient.Instance().Connect(textBoxHostname.Text,textBoxClientID.Text,
                    radioButtonSession.Checked,keepAliveSecond,
                    textBoxUsername.Text,textBoxPassword.Text);
            else
                result=MqttClient.Instance().Connect(textBoxHostname.Text, textBoxClientID.Text,
                    radioButtonSession.Checked, keepAliveSecond);
            if (result == false)
                MessageBox.Show("无法连接");

        }

        private void buttonRandomID_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            textBoxClientID.Text= guid.ToString("N");
        }
    }
}
