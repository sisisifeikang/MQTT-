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
            SetCombobox();
        }

        private void SetCombobox()
        {
            comboBoxWillQos.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (string name in StaticResources.GetNameEnumerable())
            {
                comboBoxWillQos.Items.Add(name);
            }

            comboBoxWillQos.SelectedIndex = 0;
            this.Focus();
        }

        private void SetDefaultValue()
        {
            checkBoxCleanSession.Checked = true;
            checkBoxAutoConnect.Checked = true;
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
            bool withWill = (textBoxWillTopic.Text != null && textBoxWillMessage.Text != null);

            MqttClient mqttClient = MqttClient.Instance();
            if(withWill)
                    mqttClient.SetWill(textBoxWillTopic.Text, textBoxWillMessage.Text,
                        comboBoxWillQos.SelectedText, checkBoxWillRetain.Checked);
            mqttClient.cleanSession = checkBoxCleanSession.Checked;
            mqttClient.AutoConnected = checkBoxAutoConnect.Checked;
            if (withUser)                
                result = MqttClient.Instance().Connect(textBoxHostname.Text, textBoxClientID.Text,
                    keepAliveSecond,
                    textBoxUsername.Text, textBoxPassword.Text);     
            else
                result = MqttClient.Instance().Connect(textBoxHostname.Text, textBoxClientID.Text,
                    keepAliveSecond);            
            if (result == false)
                MessageBox.Show("无法连接");
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void buttonRandomID_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            textBoxClientID.Text= guid.ToString("N");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
