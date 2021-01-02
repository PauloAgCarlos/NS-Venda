using NS_Venda.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NS_Venda.Forms
{
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");

             
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void AddControls(UserControl uc)
        {
            panelControls.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControls.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            string funcao = Properties.Settings.Default.FuncaoUsuario;
            if (funcao == "Admin")
            {
                UC_Dashboard ud = new UC_Dashboard();
                AddControls(ud);
            }
            else
            {
                MessageBox.Show("Não tens permissão para acessar!...", "Permissão negada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            UC_Vendas uv = new UC_Vendas();
            AddControls(uv);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            string funcao = Properties.Settings.Default.FuncaoUsuario;
            if (funcao=="Admin")
            {
                UC_Produtos up = new UC_Produtos();
                AddControls(up);
            }
            else
            {
                MessageBox.Show("Não tens permissão para acessar!...", "Permissão negada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            string funcao = Properties.Settings.Default.FuncaoUsuario;
            if (funcao == "Admin")
            {
                UC_Entradas uc = new UC_Entradas();
                AddControls(uc);
            }
            else
            {
                MessageBox.Show("Não tens permissão para acessar!...", "Permissão negada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            string funcao = Properties.Settings.Default.FuncaoUsuario;
            if (funcao == "Admin")
            {
                UC_Fornecedores uf = new UC_Fornecedores();
                AddControls(uf);
            }
            else
            {
                MessageBox.Show("Não tens permissão para acessar!...", "Permissão negada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            string funcao = Properties.Settings.Default.FuncaoUsuario;
            if (funcao == "Admin")
            {
                UC_Relatorios ur = new UC_Relatorios();
                AddControls(ur);
            }
            else
            {
                MessageBox.Show("Não tens permissão para acessar!...", "Permissão negada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
             
           
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string funcao = Properties.Settings.Default.FuncaoUsuario;
            if (funcao == "Admin")
            {
                UC_Usuarios uc = new UC_Usuarios();
                AddControls(uc);
            }
            else
            {
                MessageBox.Show("Não tens permissão para acessar!...", "Permissão negada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            txtNomeUsuario.Text = Properties.Settings.Default.NomeUsuario;
            txtFuncao.Text = Properties.Settings.Default.FuncaoUsuario;
            labelEmpresa.Text = Properties.Settings.Default.NomeEmpresa;
        }
    }
}
