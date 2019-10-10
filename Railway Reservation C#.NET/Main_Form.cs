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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7F8IJ89;Initial Catalog=TKT_RESN;Integrated Security=True");
            string query = " SELECT * FROM  RESN_DETAILS where USERNAME = '" +txtun.Text.Trim() + "'and PASSWORD = '" + txtpw.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            if (dt1.Rows.Count == 1)
            {
                reservation_details rd = new reservation_details();
                rd.Show();
               

            }
            else
            {
                MessageBox.Show("Check Username or Password");
                
            }
            txtun.Clear();
            txtpw.Clear();
           
           
           
           
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRAIN_INFODataSet4.TRAINS' table. You can move, or remove it, as needed.
            this.tRAINSTableAdapter3.Fill(this.tRAIN_INFODataSet4.TRAINS);
            // TODO: This line of code loads data into the 'tRAIN_INFODataSet3.TRAINS' table. You can move, or remove it, as needed.
            this.tRAINSTableAdapter2.Fill(this.tRAIN_INFODataSet3.TRAINS);
            // TODO: This line of code loads data into the 'tRAIN_INFODataSet2.TRAINS' table. You can move, or remove it, as needed.
            this.tRAINSTableAdapter.Fill(this.tRAIN_INFODataSet2.TRAINS);
           

        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7F8IJ89;Initial Catalog=train_info;Integrated Security=True");
            string query = " SELECT * FROM  trains where SOURCE = '" + comboBox1.SelectedValue.ToString() + "'and DESTINATION = '" + comboBox2.SelectedValue.ToString()+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet DS = new DataSet();
            sda.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7F8IJ89;Initial Catalog=TKT_RESN;Integrated Security=True");
            string query = "DELETE FROM [TKT_RESN].[dbo].[RESERVATION] WHERE PNR_No = '" + txtpnrno.Text.Trim() + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Cancel Successfull");
            con.Close();
            txtpnrno.Clear();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       
    }
}
