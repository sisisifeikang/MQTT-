namespace MqttClient
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIconClient = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPubMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPubTopic = new System.Windows.Forms.TextBox();
            this.comboBoxPubQos = new System.Windows.Forms.ComboBox();
            this.buttonPub = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSubTopic = new System.Windows.Forms.TextBox();
            this.comboBoxSubQos = new System.Windows.Forms.ComboBox();
            this.buttonSub = new System.Windows.Forms.Button();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.timerDetail = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.timerPublish = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.listViewTask = new System.Windows.Forms.ListView();
            this.contextMenuStripTaskList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推送任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCost = new System.Windows.Forms.Timer(this.components);
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMemory = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelConnect = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconClient
            // 
            this.notifyIconClient.ContextMenuStrip = this.contextMenuStripNotify;
            this.notifyIconClient.Text = "notifyIconClient";
            this.notifyIconClient.DoubleClick += new System.EventHandler(this.notifyIconClient_DoubleClick);
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.Name = "contextMenuStripNotify";
            this.contextMenuStripNotify.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripNotify.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripNotify_Opening);
            this.contextMenuStripNotify.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripNotify_ItemClicked);
            // 
            // timerNotify
            // 
            this.timerNotify.Enabled = true;
            this.timerNotify.Interval = 1000;
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPubMessage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPubTopic);
            this.groupBox1.Controls.Add(this.comboBoxPubQos);
            this.groupBox1.Controls.Add(this.buttonPub);
            this.groupBox1.Location = new System.Drawing.Point(29, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "推送";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "推送信息";
            // 
            // textBoxPubMessage
            // 
            this.textBoxPubMessage.Location = new System.Drawing.Point(21, 95);
            this.textBoxPubMessage.Name = "textBoxPubMessage";
            this.textBoxPubMessage.Size = new System.Drawing.Size(188, 21);
            this.textBoxPubMessage.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "推送主题";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "服务质量";
            // 
            // textBoxPubTopic
            // 
            this.textBoxPubTopic.Location = new System.Drawing.Point(21, 41);
            this.textBoxPubTopic.Name = "textBoxPubTopic";
            this.textBoxPubTopic.Size = new System.Drawing.Size(188, 21);
            this.textBoxPubTopic.TabIndex = 14;
            // 
            // comboBoxPubQos
            // 
            this.comboBoxPubQos.FormattingEnabled = true;
            this.comboBoxPubQos.Location = new System.Drawing.Point(21, 152);
            this.comboBoxPubQos.Name = "comboBoxPubQos";
            this.comboBoxPubQos.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPubQos.TabIndex = 15;
            // 
            // buttonPub
            // 
            this.buttonPub.Location = new System.Drawing.Point(182, 152);
            this.buttonPub.Name = "buttonPub";
            this.buttonPub.Size = new System.Drawing.Size(75, 23);
            this.buttonPub.TabIndex = 16;
            this.buttonPub.Text = "推送";
            this.buttonPub.UseVisualStyleBackColor = true;
            this.buttonPub.Click += new System.EventHandler(this.buttonPub_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxSubTopic);
            this.groupBox2.Controls.Add(this.comboBoxSubQos);
            this.groupBox2.Controls.Add(this.buttonSub);
            this.groupBox2.Location = new System.Drawing.Point(29, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 193);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订阅";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "订阅主题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "服务质量";
            // 
            // textBoxSubTopic
            // 
            this.textBoxSubTopic.Location = new System.Drawing.Point(21, 67);
            this.textBoxSubTopic.Name = "textBoxSubTopic";
            this.textBoxSubTopic.Size = new System.Drawing.Size(188, 21);
            this.textBoxSubTopic.TabIndex = 9;
            // 
            // comboBoxSubQos
            // 
            this.comboBoxSubQos.FormattingEnabled = true;
            this.comboBoxSubQos.Location = new System.Drawing.Point(21, 131);
            this.comboBoxSubQos.Name = "comboBoxSubQos";
            this.comboBoxSubQos.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSubQos.TabIndex = 10;
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(182, 128);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 11;
            this.buttonSub.Text = "订阅";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.Location = new System.Drawing.Point(341, 200);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.Size = new System.Drawing.Size(221, 235);
            this.textBoxDetail.TabIndex = 2;
            // 
            // timerDetail
            // 
            this.timerDetail.Enabled = true;
            this.timerDetail.Tick += new System.EventHandler(this.timerDetail_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "日志";
            // 
            // timerPublish
            // 
            this.timerPublish.Enabled = true;
            this.timerPublish.Tick += new System.EventHandler(this.timerPublish_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "推送任务列表";
            this.label8.Visible = false;
            // 
            // listViewTask
            // 
            this.listViewTask.Location = new System.Drawing.Point(418, 345);
            this.listViewTask.Name = "listViewTask";
            this.listViewTask.Size = new System.Drawing.Size(221, 146);
            this.listViewTask.TabIndex = 8;
            this.listViewTask.UseCompatibleStateImageBehavior = false;
            this.listViewTask.Visible = false;
            this.listViewTask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewTask_MouseClick);
            // 
            // contextMenuStripTaskList
            // 
            this.contextMenuStripTaskList.Name = "contextMenuStripTaskList";
            this.contextMenuStripTaskList.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.推送任务ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 推送任务ToolStripMenuItem
            // 
            this.推送任务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskAddToolStripMenuItem});
            this.推送任务ToolStripMenuItem.Name = "推送任务ToolStripMenuItem";
            this.推送任务ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.推送任务ToolStripMenuItem.Text = "推送任务";
            // 
            // TaskAddToolStripMenuItem
            // 
            this.TaskAddToolStripMenuItem.Name = "TaskAddToolStripMenuItem";
            this.TaskAddToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.TaskAddToolStripMenuItem.Text = "任务添加";
            this.TaskAddToolStripMenuItem.Click += new System.EventHandler(this.TaskAddToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // timerCost
            // 
            this.timerCost.Interval = 500;
            this.timerCost.Tick += new System.EventHandler(this.timerCost_Tick);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.labelConnect);
            this.groupBoxStatus.Controls.Add(this.labelTime);
            this.groupBoxStatus.Controls.Add(this.labelMemory);
            this.groupBoxStatus.Controls.Add(this.labelCPU);
            this.groupBoxStatus.Location = new System.Drawing.Point(341, 30);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(212, 128);
            this.groupBoxStatus.TabIndex = 11;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "状态";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(19, 76);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(41, 12);
            this.labelTime.TabIndex = 18;
            this.labelTime.Text = "时间：";
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Location = new System.Drawing.Point(19, 47);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(65, 12);
            this.labelMemory.TabIndex = 1;
            this.labelMemory.Text = "内存占用：";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(19, 17);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(59, 12);
            this.labelCPU.TabIndex = 0;
            this.labelCPU.Text = "CPU占用：";
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Location = new System.Drawing.Point(19, 102);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(65, 12);
            this.labelConnect.TabIndex = 19;
            this.labelConnect.Text = "连接状态：";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 447);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.listViewTask);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDetail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconClient;
        private System.Windows.Forms.Timer timerNotify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSubTopic;
        private System.Windows.Forms.ComboBox comboBoxSubQos;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPubTopic;
        private System.Windows.Forms.ComboBox comboBoxPubQos;
        private System.Windows.Forms.Button buttonPub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPubMessage;
        private System.Windows.Forms.TextBox textBoxDetail;
        private System.Windows.Forms.Timer timerDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerPublish;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewTask;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTaskList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 推送任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaskAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Timer timerCost;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelConnect;
    }
}