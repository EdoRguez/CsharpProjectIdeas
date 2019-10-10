
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
    public partial class Previev_Form : Form
    {
        public Previev_Form()
        {
            InitializeComponent();
        }

        public Previev_Form(string from, string to, string name, string age, string date, string clas, string ac, string sleep, string pay)
        {
            Random rr = new Random();
            int pn = rr.Next();
            InitializeComponent();
            lblpn.Text = pn.ToString();
            lblfrom.Text = from;
            lblto.Text = to;
            lblname.Text = name;
            lblage.Text = age;
            lbldate.Text = date;
            lblclas.Text = clas;
            lblac.Text = ac;
            lblsleep.Text = sleep;
            lblpay.Text = pay;
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [TKT_RESN].[dbo].[RESERVATION]([PNR_No],[FROM],[TO],[NAME],[AGE],[DATE],[CLASS],[AC],[SLEEPER],[PAYMENT_OPTION]) VALUES('" + lblpn.Text + "','" + lblfrom.Text + "','" + lblto.Text + "','" + lblname.Text + "','" + lblage.Text + "','" + lbldate.Text + "','" + lblclas.Text + "','" + lblac.Text + "','" + lblsleep.Text + "','" + lblpay.Text + "')";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7F8IJ89;Initial Catalog=TKT_RESN;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Successfull");
            this.Close();
            con.Close();
            
           
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Previev_Form_Load(object sender, EventArgs e)
        {

        }

       

       
        

       
       
    }
}
