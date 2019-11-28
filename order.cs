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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void tOrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tOrderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet9);

        }

        private void order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final1DataSet9.TOrder' table. You can move, or remove it, as needed.
            this.tOrderTableAdapter.Fill(this.final1DataSet9.TOrder);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tOrderBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tOrderBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult isExit;
            isExit = MessageBox.Show("Comfirm if you done adding Order", "Close Add Order Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tOrderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet9);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tOrderBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tOrderBindingSource.MovePrevious();
        }
    }
}
