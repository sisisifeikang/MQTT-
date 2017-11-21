using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Diagnostics;

namespace MqttClient
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void InitListView()
        {
            listViewTask.View = View.Details;
            listViewTask.GridLines = true;
            listViewTask.Items.Clear();
            listViewTask.Columns.Clear();
            listViewTask.HeaderStyle = ColumnHeaderStyle.None;
            listViewTask.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ColumnHeader columnHeader = new ColumnHeader();
            columnHeader.Text = "任务名";
            listViewTask.Columns.Add(columnHeader);

        }

        private void RedrawListViewTask()
        {

            listViewTask.Items.Clear();
            foreach (AutoPublishTask task in MqttClient.Instance().taskList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = task.TaskName;
                //listViewItem.SubItems.Add(task.TaskName);
                listViewTask.Items.Add(listViewItem);
            }
        }
                    


        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            FormConnect formConnect = new FormConnect();
            if (formConnect.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            
            this.Show();
            ShowNotifyIcon();
            SetCombobox();
            textBoxDetail.ReadOnly = true;
            InitListView();
            timerCost.Enabled = true;
        }


        private void ShowNotifyIcon()
        {
            Icon icon = new Icon("mqtt.ico");
            notifyIconClient.Icon = icon;
            notifyIconClient.Visible = true;
        }

        private void SetCombobox()
        {
            comboBoxPubQos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubQos.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach(string name in StaticResources.GetNameEnumerable())
            {
                comboBoxPubQos.Items.Add(name);
                comboBoxSubQos.Items.Add(name);
            }

            comboBoxPubQos.SelectedIndex = 0;
            comboBoxSubQos.SelectedIndex = 0;
            this.Focus();

        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MqttClient.Instance().Mqtt!=null&&MqttClient.Instance().Mqtt.IsConnected)
                MqttClient.Instance().Close();
        }

        private void notifyIconClient_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Visible)
                this.Show();            
        }

        private void timerNotify_Tick(object sender, EventArgs e)
        {
            timerNotify.Enabled = false;
            if(StaticResources.nofifyQueue.Count!=0)
                notifyIconClient.ShowBalloonTip(5000, "消息提示", StaticResources.nofifyQueue.Dequeue(), ToolTipIcon.Warning);
            timerNotify.Enabled = true;

        }

        private void contextMenuStripNotify_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Text)
            {
                case "退出":
                    MqttClient.Instance().Close();
                    this.Close();
                    break;
            }
        }


        private void contextMenuStripNotify_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuStripNotify.Items.Clear();

            contextMenuStripNotify.Items.Add("当前连接状态：" + (MqttClient.Instance().Mqtt.IsConnected == true ? "连接中" : "断开"));
            contextMenuStripNotify.Items.Add("退出");
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void buttonPub_Click(object sender, EventArgs e)
        {
            MqttClient.Instance().Publish(textBoxPubTopic.Text, textBoxPubMessage.Text,comboBoxSubQos.SelectedText,false);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            MqttClient.Instance().Subscribe(textBoxSubTopic.Text, comboBoxPubQos.SelectedText);
        }

        private void timerDetail_Tick(object sender, EventArgs e)
        {
            timerDetail.Enabled = false;
            if (StaticResources.messageQueue.Count != 0)
                textBoxDetail.AppendText(StaticResources.messageQueue.Dequeue()+"\r\n");
            timerDetail.Enabled = true;

        }

        private void timerPublish_Tick(object sender, EventArgs e)
        {
            timerPublish.Enabled = false;
            if (StaticResources.publiishQueue.Count != 0)
            {
                //publishList.Add(StaticResources.publiishQueue.Dequeue());
                LogHelper.loginfo.Info(StaticResources.publiishQueue.Dequeue());
            }
            timerPublish.Enabled = true;
        }

        private void listViewTask_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                
            }
        }

        private void TaskAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAutoPublishTaskSetting formAutoPublishTaskSetting = new FormAutoPublishTaskSetting();
            formAutoPublishTaskSetting.ShowDialog();
            RedrawListViewTask();
        }

        private void timerCost_Tick(object sender, EventArgs e)
        {
            UpdateCPU();
            labelConnect.Text = "连接状态:" + (MqttClient.Instance().Mqtt.IsConnected?"连接中":"断开");
        }

        private PerformanceCounter process = new PerformanceCounter(
            "Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
        private PerformanceCounter memory = new PerformanceCounter(
            "Process", "Working Set - Private", Process.GetCurrentProcess().ProcessName);
        private void UpdateCPU()
        {
            labelCPU.Text = "CPU占用：" + (process.NextValue() / Environment.ProcessorCount).ToString("0.00") + "%";
            labelMemory.Text = "内存占用：" + (memory.NextValue() / (1024 * 1024)).ToString("0.00") + "MB";
            labelTime.Text = "时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
