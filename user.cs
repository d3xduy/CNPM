using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void tUserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tUserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet7);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final1DataSet7.TUser' table. You can move, or remove it, as needed.
            this.tUserTableAdapter.Fill(this.final1DataSet7.TUser);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tUserBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tUserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tUserBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult isExit;
            isExit = MessageBox.Show("Comfirm if you done adding User", "Close Add User Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tUserBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tUserBindingSource.MovePrevious();
        }
    }
}
