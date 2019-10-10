using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Ticket_Reservation
{
    public partial class CreateNewAccount : Form
    {
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (txtcpw.Text == txtpw.Text)
          {
          string query = "INSERT INTO [CREATE_NEW_ACC].[dbo].[NEW_ACC] ([FIRST NAME],[LAST NAME] ,[MOBILE NO],[USERNAME] ,[PASSWORD],[CONFIRM PASSWORD]) VALUES('" + txtfn.Text + "','" + txtln.Text + "','" + txtmn.Text + "','"+txtun.Text+"','" + txtpw.Text + "','" + txtcpw.Text + "')";
          SqlConnection con = new SqlConnection("Data Source=desktop-7f8ij89;Initial Catalog=CREATE_NEW_ACC;Integrated Security=True");
          con.Open();
          SqlCommand cmd = new SqlCommand(query,con);
          cmd.ExecuteNonQuery();
         

         
              txtfn.Clear();
              txtln.Clear();
              txtmn.Clear();
              txtun.Clear();
              txtpw.Clear();
              txtcpw.Clear();
              con.Close();

          
            }
          else
          {
              MessageBox.Show("wrong password ");
              txtcpw.Clear();

          }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfn.Clear();
            txtln.Clear();
            txtmn.Clear();
            txtun.Clear();
            txtpw.Clear();
          
            txtcpw.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        

      
       


       

       

       
    }
}
