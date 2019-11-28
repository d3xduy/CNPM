using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        string constring = @"Data Source=D3X;Initial Catalog=final1;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (emailtxt.Text == "" || passtxt.Text == "" || firstnametxt.Text == "" || lastnametxt.Text == "")
            {
                MessageBox.Show("please enter all the infomation");
            }
            else if(passtxt.Text != cfmpass.Text)
            {
                MessageBox.Show("Password not match");
            }

            try
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlCommand sqlCmd = new SqlCommand("Adduser", sqlcon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Mail", emailtxt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@pass", passtxt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Name", firstnametxt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Surname", lastnametxt.Text.Trim());

                    sqlCmd.Parameters.AddWithValue("@Phone", phonetxt.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            this.Hide();
            login objfrlogin = new login();
            objfrlogin.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login objfrlogin = new login();
            objfrlogin.Show();
        }
    }
}
