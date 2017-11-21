using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfForm
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConnectWindow connectWindow = new ConnectWindow();
            connectWindow.ShowDialog();
            if(connectWindow.DialogResult!=Convert.ToBoolean(1))
            {
                this.Close();
            }
            SetCombobox();
            TimerNotify();
            NotifyIconClient();
            GridViewMessage();
        }
        ObservableCollection<Message> messageSource = new ObservableCollection<Message>();

        private void GridViewMessage()
        {
            
            gridProducts.ItemsSource = messageSource;
            ICollectionView view = CollectionViewSource.GetDefaultView(gridProducts.ItemsSource);

            view.GroupDescriptions.Add(new PropertyGroupDescription("Topic"));
        }


        private DispatcherTimer timerNotify;
        private void TimerNotify()
        {
            timerNotify = new DispatcherTimer();
            timerNotify.Interval = TimeSpan.FromMilliseconds(500);
            timerNotify.Tick += Timer_Tick;
            timerNotify.IsEnabled = true;
        }   
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (StaticResources.nofifyQueue.Count != 0)
                notifyIconClient.ShowBalloonTip(5000, "消息提示", StaticResources.nofifyQueue.Dequeue(), ToolTipIcon.Warning);
            UpdateCPU();
            labelConnect.Content = "连接状态:" + (MqttClient.Instance().Mqtt.IsConnected ? "连接中" : "断开");
            if (StaticResources.publiishQueue.Count != 0)
            {
                Message m = StaticResources.publiishQueue.Dequeue();
                messageSource.Add(m);
                LogHelper.loginfo.Info(m.ToString());
            }
            if (StaticResources.messageQueue.Count != 0)
                textBoxDetail.AppendText(StaticResources.messageQueue.Dequeue() + "\r\n");
        }

        private PerformanceCounter process = new PerformanceCounter(
            "Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
        private PerformanceCounter memory = new PerformanceCounter(
            "Process", "Working Set - Private", Process.GetCurrentProcess().ProcessName);
        private void UpdateCPU()
        {
            labelCPU.Content = "CPU占用：" + (process.NextValue() / Environment.ProcessorCount).ToString("0.00") + "%";
            labelMemory.Content = "内存占用：" + (memory.NextValue() / (1024 * 1024)).ToString("0.00") + "MB";
            labelTime.Content = "时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private NotifyIcon notifyIconClient;
        private void NotifyIconClient()
        {
           
            notifyIconClient = new NotifyIcon();
            notifyIconClient.Icon = new System.Drawing.Icon("letter-m.ico");
            notifyIconClient.Text = "Mqtt客户端";
            notifyIconClient.Visible = true;
            notifyIconClient.MouseClick += NotifyIconClient_MouseClick;
        }
        private void NotifyIconClient_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string strM1 = MqttClient.Instance().Mqtt.IsConnected ? "当前状态:连接中" : "断开";
                System.Windows.Forms.MenuItem m1 = new System.Windows.Forms.MenuItem(strM1);
                System.Windows.Forms.MenuItem m2 = new System.Windows.Forms.MenuItem("退出");
                m2.Click += m2_Click;
                System.Windows.Forms.MenuItem[] m = new System.Windows.Forms.MenuItem[] { m1, m2 };
                this.notifyIconClient.ContextMenu = new System.Windows.Forms.ContextMenu(m);
            }
        }
        private void m2_Click(object sender, EventArgs e)
        {
            MqttClient.Instance().Close();
            this.Close();
        }

        private void SetCombobox()
        {
            foreach (string name in StaticResources.GetNameEnumerable())
            {
                comboBoxPubQos.Items.Add(name);
                comboBoxSubQos.Items.Add(name);
            }

            comboBoxPubQos.SelectedIndex = 0;
            comboBoxSubQos.SelectedIndex = 0;
            this.Focus();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MqttClient.Instance().Mqtt != null && MqttClient.Instance().Mqtt.IsConnected)
                MqttClient.Instance().Close();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
                this.Hide();
        }

        private void buttonSub_Click(object sender, RoutedEventArgs e)
        {
            MqttClient.Instance().Subscribe(textBoxSubTopic.Text, comboBoxPubQos.SelectedValue.ToString());
        }

        private void buttonPub_Click(object sender, RoutedEventArgs e)
        {
            MqttClient.Instance().Publish(textBoxPubTopic.Text, textBoxPubMessage.Text, comboBoxSubQos.SelectedValue.ToString(), false);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            PublishWindow publishWindow = new PublishWindow();
            publishWindow.Show();
        }
    }
}
