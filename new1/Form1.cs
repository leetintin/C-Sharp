using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace new1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List 1.0. \nWritten by: your Name", "About");
        }

        private void propleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void propleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.propleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void propleBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.propleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.prople' table. You can move, or remove it, as needed.
            this.propleTableAdapter.Fill(this.database1DataSet.prople);

        }

        private void clientCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void contactIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyLabel_Click(object sender, EventArgs e)
        {

        }

        private void companyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telephoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastCallLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastCallDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
