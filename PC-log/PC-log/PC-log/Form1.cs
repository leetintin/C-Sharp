using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PC_log
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“database2DataSet2.PClog”中。您可以根据需要移动或删除它。
            this.pClogTableAdapter1.Fill(this.database2DataSet2.PClog);
            // TODO: 这行代码将数据加载到表“database2DataSet1.PClog”中。您可以根据需要移动或删除它。
            this.pClogTableAdapter.Fill(this.database2DataSet1.PClog);

        }

        private void pClogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pClogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet1);

        }

        private void iDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
