namespace MqttClient
{
    partial class FormConnect
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRandomID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.textBoxAlive = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxWillQos = new System.Windows.Forms.ComboBox();
            this.checkBoxWillRetain = new System.Windows.Forms.CheckBox();
            this.textBoxWillTopic = new System.Windows.Forms.TextBox();
            this.textBoxWillMessage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxCleanSession = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoConnect = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRandomID
            // 
            this.buttonRandomID.Location = new System.Drawing.Point(361, 112);
            this.buttonRandomID.Name = "buttonRandomID";
            this.buttonRandomID.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomID.TabIndex = 2;
            this.buttonRandomID.Text = "随机生成";
            this.buttonRandomID.UseVisualStyleBackColor = true;
            this.buttonRandomID.Click += new System.EventHandler(this.buttonRandomID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "客户端ID";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(56, 112);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(274, 21);
            this.textBoxClientID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "主机名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "心跳包间隔(秒)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "会话";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "自动连接";
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(56, 51);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(274, 21);
            this.textBoxHostname.TabIndex = 10;
            // 
            // textBoxAlive
            // 
            this.textBoxAlive.Location = new System.Drawing.Point(327, 170);
            this.textBoxAlive.Name = "textBoxAlive";
            this.textBoxAlive.Size = new System.Drawing.Size(100, 21);
            this.textBoxAlive.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(400, 466);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "退出";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(293, 466);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 15;
            this.buttonConnect.Text = "连接";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(56, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 263);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可选项";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxWillQos);
            this.groupBox2.Controls.Add(this.checkBoxWillRetain);
            this.groupBox2.Controls.Add(this.textBoxWillTopic);
            this.groupBox2.Controls.Add(this.textBoxWillMessage);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(23, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "遗嘱";
            // 
            // comboBoxWillQos
            // 
            this.comboBoxWillQos.FormattingEnabled = true;
            this.comboBoxWillQos.Location = new System.Drawing.Point(13, 104);
            this.comboBoxWillQos.Name = "comboBoxWillQos";
            this.comboBoxWillQos.Size = new System.Drawing.Size(121, 20);
            this.comboBoxWillQos.TabIndex = 8;
            // 
            // checkBoxWillRetain
            // 
            this.checkBoxWillRetain.AutoSize = true;
            this.checkBoxWillRetain.Location = new System.Drawing.Point(214, 108);
            this.checkBoxWillRetain.Name = "checkBoxWillRetain";
            this.checkBoxWillRetain.Size = new System.Drawing.Size(48, 16);
            this.checkBoxWillRetain.TabIndex = 7;
            this.checkBoxWillRetain.Text = "保留";
            this.checkBoxWillRetain.UseVisualStyleBackColor = true;
            // 
            // textBoxWillTopic
            // 
            this.textBoxWillTopic.Location = new System.Drawing.Point(13, 31);
            this.textBoxWillTopic.Name = "textBoxWillTopic";
            this.textBoxWillTopic.Size = new System.Drawing.Size(150, 21);
            this.textBoxWillTopic.TabIndex = 5;
            // 
            // textBoxWillMessage
            // 
            this.textBoxWillMessage.Location = new System.Drawing.Point(13, 69);
            this.textBoxWillMessage.Name = "textBoxWillMessage";
            this.textBoxWillMessage.Size = new System.Drawing.Size(150, 21);
            this.textBoxWillMessage.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "遗嘱保留";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "服务质量";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "遗嘱信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "遗嘱主题";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(23, 86);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(251, 21);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(21, 43);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(251, 21);
            this.textBoxUsername.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "用户名";
            // 
            // checkBoxCleanSession
            // 
            this.checkBoxCleanSession.AutoSize = true;
            this.checkBoxCleanSession.Location = new System.Drawing.Point(56, 170);
            this.checkBoxCleanSession.Name = "checkBoxCleanSession";
            this.checkBoxCleanSession.Size = new System.Drawing.Size(72, 16);
            this.checkBoxCleanSession.TabIndex = 17;
            this.checkBoxCleanSession.Text = "清理会话";
            this.checkBoxCleanSession.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoConnect
            // 
            this.checkBoxAutoConnect.AutoSize = true;
            this.checkBoxAutoConnect.Location = new System.Drawing.Point(191, 170);
            this.checkBoxAutoConnect.Name = "checkBoxAutoConnect";
            this.checkBoxAutoConnect.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAutoConnect.TabIndex = 18;
            this.checkBoxAutoConnect.Text = "自动连接";
            this.checkBoxAutoConnect.UseVisualStyleBackColor = true;
            // 
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 501);
            this.Controls.Add(this.checkBoxAutoConnect);
            this.Controls.Add(this.checkBoxCleanSession);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxAlive);
            this.Controls.Add(this.textBoxHostname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRandomID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormConnect";
            this.Text = "MQTT客户端登陆";
            this.Load += new System.EventHandler(this.FormConnect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRandomID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.TextBox textBoxAlive;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxWillQos;
        private System.Windows.Forms.CheckBox checkBoxWillRetain;
        private System.Windows.Forms.TextBox textBoxWillTopic;
        private System.Windows.Forms.TextBox textBoxWillMessage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCleanSession;
        private System.Windows.Forms.CheckBox checkBoxAutoConnect;
    }
}

