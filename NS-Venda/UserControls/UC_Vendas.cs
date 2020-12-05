using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLRDbConnector;

namespace NS_Venda.UserControls
{
    public partial class UC_Vendas : UserControl
    {
        DbConnector db; 
        public UC_Vendas()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "" || txtQtd.Text=="")
            {
                MessageBox.Show("Preecha todos os campos","Preencher Campos!...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listView1.Items.Add(nome);
                txtID.Text = "";
                txtNome.Text = "";
                txtPreco.Text = "";
                txtExistencia.Text = "";
                txtQtd.Text = "";
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string produtoId, nome, preco, existencia;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                produtoId = item.Cells[0].Value.ToString();
                nome = item.Cells[1].Value.ToString();
                preco = item.Cells[2].Value.ToString();
                existencia = item.Cells[3].Value.ToString();


                btnAdicionar.Enabled = true;
                txtID.Text = produtoId;
                txtNome.Text = nome;
                txtPreco.Text = preco;
                txtExistencia.Text = existencia;
            }
        }

        private void UC_Vendas_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from tblProdutos", dataGridView1);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string query = "";

            if (txtNome.Text!=null)
            {

                dataGridView1.Visible = true;
             
                query = "select * from tblProdutos where nome like '%" + txtNome.Text + "%'";
           
            db.fillDataGridView(query, dataGridView1);

            }

            if (txtNome.Text == "")
            {
                dataGridView1.Visible = false;
                btnAdicionar.Visible = true;
            }
             
        }
    }
}
