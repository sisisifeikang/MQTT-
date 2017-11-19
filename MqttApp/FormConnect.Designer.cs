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
            this.radioButtonSession = new System.Windows.Forms.RadioButton();
            this.radioButtonConnection = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRandomID
            // 
            this.buttonRandomID.Location = new System.Drawing.Point(359, 153);
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
            this.label2.Location = new System.Drawing.Point(52, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "客户端ID";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(54, 153);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(274, 21);
            this.textBoxClientID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "主机名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "心跳包间隔(秒)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "会话";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "自动连接";
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(54, 92);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(274, 21);
            this.textBoxHostname.TabIndex = 10;
            // 
            // textBoxAlive
            // 
            this.textBoxAlive.Location = new System.Drawing.Point(325, 211);
            this.textBoxAlive.Name = "textBoxAlive";
            this.textBoxAlive.Size = new System.Drawing.Size(100, 21);
            this.textBoxAlive.TabIndex = 11;
            // 
            // radioButtonSession
            // 
            this.radioButtonSession.AutoSize = true;
            this.radioButtonSession.Location = new System.Drawing.Point(56, 211);
            this.radioButtonSession.Name = "radioButtonSession";
            this.radioButtonSession.Size = new System.Drawing.Size(71, 16);
            this.radioButtonSession.TabIndex = 12;
            this.radioButtonSession.TabStop = true;
            this.radioButtonSession.Text = "清理会话";
            this.radioButtonSession.UseVisualStyleBackColor = true;
            // 
            // radioButtonConnection
            // 
            this.radioButtonConnection.AutoSize = true;
            this.radioButtonConnection.Location = new System.Drawing.Point(189, 211);
            this.radioButtonConnection.Name = "radioButtonConnection";
            this.radioButtonConnection.Size = new System.Drawing.Size(71, 16);
            this.radioButtonConnection.TabIndex = 13;
            this.radioButtonConnection.TabStop = true;
            this.radioButtonConnection.Text = "自动连接";
            this.radioButtonConnection.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(400, 466);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "退出";
            this.buttonClose.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(56, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 198);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可选项";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(21, 93);
            this.textBoxPassword.Name = "textBoxPassword";
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
            this.label8.Location = new System.Drawing.Point(19, 78);
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
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.radioButtonConnection);
            this.Controls.Add(this.radioButtonSession);
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
        private System.Windows.Forms.RadioButton radioButtonSession;
        private System.Windows.Forms.RadioButton radioButtonConnection;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
    }
}

