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
    public partial class reservation_details : Form
    {
        public reservation_details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT *  FROM [TKT_RESN].[dbo].[RESERVATION]";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7F8IJ89;Initial Catalog=TKT_RESN;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv_reservationdetails.DataSource = ds.Tables[0];
            cmd.ExecuteNonQuery();
            con.Close();

      
     
 
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
