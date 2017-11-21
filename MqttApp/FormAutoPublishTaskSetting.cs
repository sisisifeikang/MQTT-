using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MqttClient
{
    public partial class FormAutoPublishTaskSetting : Form
    {
        public FormAutoPublishTaskSetting()
        {
            InitializeComponent();
        }
        private AutoPublishTask AutoPublishTask = null;

        private void FormAutoPublishTaskSetting_Load(object sender, EventArgs e)
        {
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
        private void SetEnable(bool enable)
        {
            textBoxPubTopic.Enabled = enable;
            textBoxValue.Enabled = enable;
            textBoxProperty.Enabled = enable;
            comboBoxPubQos.Enabled = enable;
            checkBoxRetained.Enabled = enable;
            comboBoxValueType.Enabled = enable;
            numericUpDownMin.Enabled = enable;
            numericUpDownSec.Enabled = enable;
        }

        private void SetRun(bool isRunnging)
        {
            if (isRunnging)
                buttonHandle.Text = "开始";
            else
                buttonHandle.Text = "停止";
        }
        

        private void InitComboBox()
        {
            comboBoxValueType.Items.Add(typeof(string));
            comboBoxValueType.Items.Add(typeof(int));
            comboBoxValueType.Items.Add(typeof(float));
            comboBoxValueType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxValueType.SelectedIndex = 0;

            comboBoxPubQos.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string name in StaticResources.GetNameEnumerable())
            {
                comboBoxPubQos.Items.Add(name);
            }
            comboBoxPubQos.SelectedIndex = 0;
            this.Focus();
        }

        private void InitDataGridView()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Property", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));

            dataGridViewMessage.AutoResizeColumns();
            dataGridViewMessage.DataSource = dataTable;
            foreach(DataGridViewColumn dgvc in dataGridViewMessage.Columns)
            {
                dgvc.ReadOnly = true;
            }
            dataGridViewMessage.MultiSelect = false;
            dataGridViewMessage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (dataGridViewMessage.DataSource as DataTable);
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
            if(haveSame==true)
            {
                MessageBox.Show("具有相同的属性名", " 提示");
                return;
            }

            dataRow["Property"] = textBoxProperty.Text;
            dataRow["Description"] = comboBoxValueType.SelectedItem+":"+textBoxValue.Text;

            dataTable.Rows.Add(dataRow);
            dataGridViewMessage.DataSource = dataTable;
        }

        private void dataGridViewMessage_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                if(e.RowIndex!=-1&&e.ColumnIndex!=-1)
                {

                    contextMenuStripGridView.Show(e.Location);
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMessage.Rows.Remove(dataGridViewMessage.Rows[dataGridViewMessage.CurrentCell.RowIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHandle_Click(object sender, EventArgs e)
        {
            string topic = textBoxPubTopic.Text;
            string qosname = comboBoxPubQos.SelectedItem.ToString();
            int time = Convert.ToInt32(numericUpDownMin.Value * 60 + numericUpDownSec.Value);
            bool retained = checkBoxRetained.Checked;
            DataTable dataTable = dataGridViewMessage.DataSource as DataTable;
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
