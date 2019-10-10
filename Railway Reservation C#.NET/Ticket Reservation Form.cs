using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Ticket_Reservation
{
    public partial class Otr : Form
    {
        public Otr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbfrom.SelectedIndex = -1;
            cmbto.SelectedIndex = -1;
            txtname.Clear();
            txtage.Clear();
            dtpdate.Text = null;
            rdbfc.Checked = false;
            rdbsc.Checked = false;
            rdbtc.Checked = false;
            rdbyes.Checked = false;
            rdbno.Checked = false;
            rdbys.Checked = false;
            rdbN.Checked = false;
            rdbcc.Checked = false;
            rdbdc.Checked = false;
            rdbnb.Checked = false;

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            //string pn = txtpn.Text;
            string from = cmbfrom.SelectedValue.ToString();
            string to = cmbto.SelectedValue.ToString();
            string name = txtname.Text;
            string age = txtage.Text;
            string date = dtpdate.Value.ToLongDateString();
          
            string clas = string.Empty;
            if (rdbfc.Checked)
            {
                clas = rdbfc.Text;
            }
            else if (rdbsc.Checked)
            {
                clas = rdbsc.Text;
            }
            else if (rdbtc.Checked)
            {
                clas = rdbtc.Text;
            }
            string ac = string.Empty;
            if (rdbyes.Checked)
            {
                ac = rdbyes.Text;
            }
           else if (rdbno.Checked)
            {
                ac = rdbno.Text;
            }
            string sleep = string.Empty;
            if(rdbys.Checked)
            {
                sleep = rdbys.Text;
            }
            else if(rdbN.Checked)
            {
                sleep = rdbN.Text;
            }
             string pay = string.Empty;
             if (rdbcc.Checked)
             {
                 pay = rdbcc.Text;
             }
             if (rdbdc.Checked)
             {
                 pay = rdbdc.Text;
             }
             if (rdbnb.Checked)
             {
                 pay = rdbnb.Text;
             }
              
            Previev_Form pf = new Previev_Form(from,to,name,age,date,clas,ac,sleep,pay);
            pf.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Otr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRAIN_INFODataSet6.TRAINS' table. You can move, or remove it, as needed.
            this.tRAINSTableAdapter1.Fill(this.tRAIN_INFODataSet6.TRAINS);
            // TODO: This line of code loads data into the 'tRAIN_INFODataSet5.TRAINS' table. You can move, or remove it, as needed.
            this.tRAINSTableAdapter.Fill(this.tRAIN_INFODataSet5.TRAINS);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tRAINSTableAdapter.FillBy(this.tRAIN_INFODataSet5.TRAINS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tRAINSTableAdapter1.FillBy(this.tRAIN_INFODataSet6.TRAINS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tRAINSTableAdapter.FillBy1(this.tRAIN_INFODataSet5.TRAINS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

       

       

        

       
        
       
        

       
    }
}
