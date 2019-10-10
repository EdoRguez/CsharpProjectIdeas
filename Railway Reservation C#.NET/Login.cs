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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateNewAccount lg = new CreateNewAccount();
            lg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string query = "INSERT INTO [LOGIN].[dbo].[LOGIN] ([USERNAME] ,[PASSWORD]) VALUES('" + txtun.Text + "','" + txtpw.Text + "')";
          //  SqlConnection con = new SqlConnection("Data Source=desktop-7f8ij89;Initial Catalog=LOGIN;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
       
          //  con.Close();
            SqlConnection con = new SqlConnection("Data Source=desktop-7f8ij89;Initial Catalog=CREATE_NEW_ACC;Integrated Security=True");
            string query = " Select * from NEW_ACC where USERNAME  = '" + txtun.Text.Trim() + "' and PASSWORD = '" + txtpw.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            if (dt1.Rows.Count == 1)
            {
                Otr obj = new Otr();
                this.Hide();
                obj.Show();
               
            }
            else 
            {
                MessageBox.Show( "Check Username or Password" );
            }

            txtun.Clear();
            txtpw.Clear();
        }
    }
}
