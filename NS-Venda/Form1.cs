using NS_Venda.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NS_Venda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.ShowDialog();
            this.Dispose();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            dateTimePicker1.Visible = false;
            DateTime hoje;
            hoje = DateTime.Today;
            
            labelHoje.Text = hoje.ToString("dd/MM/yyyy");
            if (hoje < dateTimePicker1.Value)
            {
                labelAcertarHora.Visible = true;
                labelPronto.Visible = false;
                btnEntrar.Enabled = false;
            }

            else if (hoje > dateTimePicker2.Value)
            {
                labelTrial.Visible = true;
                labelPronto.Visible = false;
                btnEntrar.Enabled = false;
            }
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
