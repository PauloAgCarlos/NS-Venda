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
            UC_Dashboard ud = new UC_Dashboard();
            AddControls(ud);
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            UC_Vendas uv = new UC_Vendas();
            AddControls(uv);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            UC_Produtos up = new UC_Produtos();
            AddControls(up);
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            UC_Clientes uc = new UC_Clientes();
            AddControls(uc);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UC_Fornecedores uf = new UC_Fornecedores();
            AddControls(uf);
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            UC_Relatorios ur = new UC_Relatorios();
            AddControls(ur);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            UC_Configuracoes uc = new UC_Configuracoes();
            AddControls(uc);
        }
    }
}
