using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfForm
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ConnectWindow : Window
    {
        public ConnectWindow()
        {
            InitializeComponent();
            SetCombobox();
            SetDefaultValue();
        }

        private void SetCombobox()
        {
            foreach (string name in StaticResources.GetNameEnumerable())
            {
                comboBoxWillQos.Items.Add(name);
            }

            comboBoxWillQos.SelectedIndex = 0;
            this.Focus();
        }

        private void SetDefaultValue()
        {
            checkBoxCleanSession.IsChecked = true;
            checkBoxAutoConnect.IsChecked = true;
            textBoxAlive.Text = "120";
            textBoxHostname.Text = "tcp://localhost:1883";
        }

        private void buttonConnect_Click(object sender, RoutedEventArgs e)
        {
            bool withUser = (textBoxUsername.Text != "" && textBoxPassword.Password != "");
            bool result = false;

            ushort keepAliveSecond;
            if (!ushort.TryParse(textBoxAlive.Text, out keepAliveSecond))
            {
                MessageBox.Show("心跳包间隔时间范围为0-255秒");
                return;
            }
            bool withWill = (textBoxWillTopic.Text != "" && textBoxWillMessage.Text != "");

            MqttClient mqttClient = MqttClient.Instance();
            if (withWill)
                mqttClient.SetWill(textBoxWillTopic.Text, textBoxWillMessage.Text,
                    comboBoxWillQos.SelectedValue.ToString(), Convert.ToBoolean(checkBoxWillRetain.IsChecked));
            mqttClient.cleanSession = Convert.ToBoolean(checkBoxCleanSession.IsChecked);
            mqttClient.AutoConnected = Convert.ToBoolean(checkBoxAutoConnect.IsChecked);
            if (withUser)
                result = mqttClient.Connect(textBoxHostname.Text, textBoxClientID.Text,
                    keepAliveSecond,
                    textBoxUsername.Text, textBoxPassword.Password);
            else
                result = mqttClient.Connect(textBoxHostname.Text, textBoxClientID.Text,
                    keepAliveSecond);
            if (result == false)
                MessageBox.Show("无法连接");
            else
            {
                this.DialogResult = true;
                this.Close();
            }
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Guid guid = Guid.NewGuid();
            textBoxClientID.Text = guid.ToString("N");
        }
    }
}
