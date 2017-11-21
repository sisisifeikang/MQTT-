using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace WpfForm
{
    /// <summary>
    /// PublishWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PublishWindow : Window
    {
        private AutoPublishTask AutoPublishTask = null;
        public PublishWindow()
        {
            InitializeComponent();
            InitDataGridView();
            InitComboBox();
            if (AutoPublishTask == null)
            {
                SetEnable(true);
                SetRun(true);
            }
            else
            {
                if (AutoPublishTask.IsRun)
                {
                    SetEnable(false);
                    SetRun(!AutoPublishTask.IsRun);
                }
                else
                {
                    SetEnable(true);
                    SetRun(true);
                }
            }

        }
        private void InitDataGridView()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Property", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));

            dataGridViewMessage.ItemsSource = dataTable.DefaultView;
        }
        private void SetRun(bool isRunnging)
        {
            if (isRunnging)
                buttonHandle.Content = "开始";
            else
                buttonHandle.Content = "停止";
        }
        private void SetEnable(bool enable)
        {
            textBoxPubTopic.IsEnabled = enable;
            textBoxValue.IsEnabled = enable;
            textBoxProperty.IsEnabled = enable;
            comboBoxPubQos.IsEnabled = enable;
            checkBoxRetained.IsEnabled = enable;
            comboBoxValueType.IsEnabled = enable;
            textBoxSec.IsEnabled = enable;
        }
        private void InitComboBox()
        {
            comboBoxValueType.Items.Add(typeof(string));
            comboBoxValueType.Items.Add(typeof(int));
            comboBoxValueType.Items.Add(typeof(float));
            comboBoxValueType.SelectedIndex = 0;
            foreach (string name in StaticResources.GetNameEnumerable())
            {
                comboBoxPubQos.Items.Add(name);
            }
            comboBoxPubQos.SelectedIndex = 0;
            this.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string topic = textBoxPubTopic.Text;
            string qosname = comboBoxPubQos.SelectedItem.ToString();
            int time = Convert.ToInt32(textBoxSec.Text);
            bool retained = Convert.ToBoolean(checkBoxRetained.IsChecked);
            DataTable dataTable = ((DataView)dataGridViewMessage.ItemsSource).Table;
            if (AutoPublishTask == null)
            {
                if (topic == "")
                {
                    MessageBox.Show("主题名为空", "提示");
                    textBoxPubTopic.Focus();
                    return;
                }
                if (qosname == "")
                {
                    MessageBox.Show("服务质量为空", "提示");
                    comboBoxPubQos.Focus();
                    return;
                }
                if (time == 0)
                    MessageBox.Show("周期时间为0", "提示");
                if (dataTable.Rows.Count == 0)
                    MessageBox.Show("没有定义消息主体", "提示");
                AutoPublishTask = new AutoPublishTask(time, topic, dataTable, qosname, retained);
                MqttClient.Instance().taskList.Add(AutoPublishTask);
                AutoPublishTask.Run();

                SetEnable(true);
                SetRun(false);

            }
            else
            {
                if (AutoPublishTask.IsRun)
                {
                    AutoPublishTask.Stop();
                    SetEnable(true);
                }
                else
                {
                    if (topic == "")
                    {
                        MessageBox.Show("主题名为空", "提示");
                        textBoxPubTopic.Focus();
                        return;
                    }
                    if (qosname == "")
                    {
                        MessageBox.Show("服务质量为空", "提示");
                        comboBoxPubQos.Focus();
                        return;
                    }
                    if (time == 0)
                        MessageBox.Show("周期时间为0", "提示");
                    if (dataTable.Rows.Count == 0)
                        MessageBox.Show("没有定义消息主体", "提示");
                    AutoPublishTask.Reset(time, topic, dataTable, qosname, retained);
                    AutoPublishTask.Run();

                    SetEnable(true);
                    SetRun(false);

                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = ((DataView)dataGridViewMessage.ItemsSource).Table;
            DataRow dataRow = dataTable.NewRow();
            bool haveSame = false;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Property"].ToString() == textBoxProperty.Text)
                {
                    haveSame = true;
                    break;
                }
            }
            if (haveSame == true)
            {
                MessageBox.Show("具有相同的属性名", " 提示");
                return;
            }

            dataRow["Property"] = textBoxProperty.Text;
            dataRow["Description"] = comboBoxValueType.SelectedItem + ":" + textBoxValue.Text;

            dataTable.Rows.Add(dataRow);
            dataGridViewMessage.ItemsSource = dataTable.DefaultView;
        }
    }
}
