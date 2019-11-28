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
    public partial class addcate : Form
    {
        public addcate()
        {
            InitializeComponent();
        }

        private void tCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet4);

        }

        private void addcate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final1DataSet4.TCategory' table. You can move, or remove it, as needed.
            this.tCategoryTableAdapter.Fill(this.final1DataSet4.TCategory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tCategoryBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tCategoryBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
                DialogResult isExit;
                isExit = MessageBox.Show("Comfirm if you done adding Category", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isExit == DialogResult.Yes)
                {
                    this.Close();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tCategoryBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tCategoryBindingSource.MovePrevious();
        }
    }
}
