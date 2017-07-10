using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PC_log_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“database1DataSet1._Pc_log_B”中。您可以根据需要移动或删除它。
            this.pc_log_BTableAdapter.Fill(this.database1DataSet1._Pc_log_B);
            // TODO: 这行代码将数据加载到表“database1DataSet1._Pc_log_B”中。您可以根据需要移动或删除它。
            this.pc_log_BTableAdapter.Fill(this.database1DataSet1._Pc_log_B);

        }

        private void pc_log_BBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_log_BBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void pc_log_BBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_log_BBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_log_BBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);
        }
    }
}
