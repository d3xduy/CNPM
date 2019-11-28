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
    public partial class addproduct1 : Form
    {
        public addproduct1()
        {
            InitializeComponent();
        }

        private void tProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet11);

        }

        private void addproduct1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final1DataSet11.TProducent' table. You can move, or remove it, as needed.
            this.tProducentTableAdapter.Fill(this.final1DataSet11.TProducent);
            // TODO: This line of code loads data into the 'final1DataSet11.TCategory' table. You can move, or remove it, as needed.
            this.tCategoryTableAdapter.Fill(this.final1DataSet11.TCategory);
            // TODO: This line of code loads data into the 'final1DataSet11.TProduct' table. You can move, or remove it, as needed.
            this.tProductTableAdapter.Fill(this.final1DataSet11.TProduct);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tProductBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tProductBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet11);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult isExit;
            isExit = MessageBox.Show("Comfirm if you done adding Product", "Close Add Product Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tProductBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tProductBindingSource.MovePrevious();
        }
    }
}
