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
    public partial class clients : Form
    {
        public clients()
        {
            InitializeComponent();
        }

        private void tAddressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAddressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet6);

        }

        private void clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final1DataSet6.TAddress' table. You can move, or remove it, as needed.
            this.tAddressTableAdapter.Fill(this.final1DataSet6.TAddress);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tAddressBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tAddressBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult isExit;
            isExit = MessageBox.Show("Comfirm if you done adding address", "Close Address Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAddressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tAddressBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tAddressBindingSource.MovePrevious();
        }
    }
}

