namespace MqttClient
{
    partial class FormAutoPublishTaskSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxRetained = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxValueType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownSec = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.textBoxProperty = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMessage = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPubTopic = new System.Windows.Forms.TextBox();
            this.comboBoxPubQos = new System.Windows.Forms.ComboBox();
            this.buttonHandle = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.contextMenuStripGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessage)).BeginInit();
            this.contextMenuStripGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTaskName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.checkBoxRetained);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxValueType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDownSec);
            this.groupBox1.Controls.Add(this.numericUpDownMin);
            this.groupBox1.Controls.Add(this.textBoxProperty);
            this.groupBox1.Controls.Add(this.textBoxValue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewMessage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPubTopic);
            this.groupBox1.Controls.Add(this.comboBoxPubQos);
            this.groupBox1.Location = new System.Drawing.Point(45, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "推送";
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(43, 41);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(188, 21);
            this.textBoxTaskName.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "任务名";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(625, 272);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxRetained
            // 
            this.checkBoxRetained.AutoSize = true;
            this.checkBoxRetained.Location = new System.Drawing.Point(43, 190);
            this.checkBoxRetained.Name = "checkBoxRetained";
            this.checkBoxRetained.Size = new System.Drawing.Size(48, 16);
            this.checkBoxRetained.TabIndex = 32;
            this.checkBoxRetained.Text = "保留";
            this.checkBoxRetained.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "是否保留";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "值类型";
            // 
            // comboBoxValueType
            // 
            this.comboBoxValueType.FormattingEnabled = true;
            this.comboBoxValueType.Location = new System.Drawing.Point(328, 275);
            this.comboBoxValueType.Name = "comboBoxValueType";
            this.comboBoxValueType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxValueType.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "秒";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "分";
            // 
            // numericUpDownSec
            // 
            this.numericUpDownSec.Location = new System.Drawing.Point(129, 236);
            this.numericUpDownSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSec.Name = "numericUpDownSec";
            this.numericUpDownSec.Size = new System.Drawing.Size(63, 21);
            this.numericUpDownSec.TabIndex = 26;
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(43, 236);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(63, 21);
            this.numericUpDownMin.TabIndex = 25;
            // 
            // textBoxProperty
            // 
            this.textBoxProperty.Location = new System.Drawing.Point(328, 227);
            this.textBoxProperty.Name = "textBoxProperty";
            this.textBoxProperty.Size = new System.Drawing.Size(100, 21);
            this.textBoxProperty.TabIndex = 24;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(472, 274);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(127, 21);
            this.textBoxValue.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "属性名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "值或范围";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "时间间隔";
            // 
            // dataGridViewMessage
            // 
            this.dataGridViewMessage.AllowUserToAddRows = false;
            this.dataGridViewMessage.AllowUserToResizeRows = false;
            this.dataGridViewMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessage.Location = new System.Drawing.Point(328, 41);
            this.dataGridViewMessage.Name = "dataGridViewMessage";
            this.dataGridViewMessage.RowTemplate.Height = 23;
            this.dataGridViewMessage.Size = new System.Drawing.Size(372, 157);
            this.dataGridViewMessage.TabIndex = 18;
            this.dataGridViewMessage.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMessage_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "推送信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "推送主题";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "服务质量";
            // 
            // textBoxPubTopic
            // 
            this.textBoxPubTopic.Location = new System.Drawing.Point(43, 80);
            this.textBoxPubTopic.Name = "textBoxPubTopic";
            this.textBoxPubTopic.Size = new System.Drawing.Size(188, 21);
            this.textBoxPubTopic.TabIndex = 14;
            this.textBoxPubTopic.Text = " ";
            // 
            // comboBoxPubQos
            // 
            this.comboBoxPubQos.FormattingEnabled = true;
            this.comboBoxPubQos.Location = new System.Drawing.Point(43, 135);
            this.comboBoxPubQos.Name = "comboBoxPubQos";
            this.comboBoxPubQos.Size = new System.Drawing.Size(187, 20);
            this.comboBoxPubQos.TabIndex = 15;
            // 
            // buttonHandle
            // 
            this.buttonHandle.Location = new System.Drawing.Point(567, 385);
            this.buttonHandle.Name = "buttonHandle";
            this.buttonHandle.Size = new System.Drawing.Size(75, 23);
            this.buttonHandle.TabIndex = 33;
            this.buttonHandle.Text = "buttonHandle";
            this.buttonHandle.UseVisualStyleBackColor = true;
            this.buttonHandle.Click += new System.EventHandler(this.buttonHandle_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(670, 385);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 34;
            this.buttonClose.Text = "退出";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // contextMenuStripGridView
            // 
            this.contextMenuStripGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.contextMenuStripGridView.Name = "contextMenuStripGridView";
            this.contextMenuStripGridView.Size = new System.Drawing.Size(101, 26);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.DeleteToolStripMenuItem.Text = "删除";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // FormAutoPublishTaskSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 436);
            this.Controls.Add(this.buttonHandle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAutoPublishTaskSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动推送任务设置";
            this.Load += new System.EventHandler(this.FormAutoPublishTaskSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessage)).EndInit();
            this.contextMenuStripGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPubTopic;
        private System.Windows.Forms.ComboBox comboBoxPubQos;
        private System.Windows.Forms.DataGridView dataGridViewMessage;
        private System.Windows.Forms.TextBox textBoxProperty;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownSec;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxValueType;
        private System.Windows.Forms.CheckBox checkBoxRetained;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonHandle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGridView;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Label label11;
    }
}