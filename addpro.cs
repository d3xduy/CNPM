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
    public partial class addpro : Form
    {
        public addpro()
        {
            InitializeComponent();
        }

        private void tProducentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tProducentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet5);

        }

        private void addpro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final1DataSet5.TProducent' table. You can move, or remove it, as needed.
            this.tProducentTableAdapter.Fill(this.final1DataSet5.TProducent);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tProducentBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tProducentBindingSource.MoveNext();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tProducentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final1DataSet5);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult isExit;
            isExit = MessageBox.Show("Comfirm if you done adding producent", "Add Producent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.tProducentBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tProducentBindingSource.RemoveCurrent();
        }
    }
}
