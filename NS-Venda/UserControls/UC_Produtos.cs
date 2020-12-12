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
using NS_Venda.Forms;

namespace NS_Venda.UserControls
{
    public partial class UC_Produtos : UserControl
    {
        DbConnector db;
        public UC_Produtos()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Produtos_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from tblProdutos", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            btnApagar.Enabled = false;
            btnEditar.Enabled = false;
            if (txtPesquisar.Text != null)
            {

                dataGridView1.Visible = true;

                query = "select * from tblProdutos where nome like '%" + txtPesquisar.Text + "%'";

                db.fillDataGridView(query, dataGridView1);

            }

            if (txtPesquisar.Text == "")
            {
                 
                btnApagar.Enabled = false;
                btnEditar.Enabled = false;
            }
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


                btnApagar.Enabled = true;
                btnEditar.Enabled = true;
                 
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.OnLoad(e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (produtoId != null)
            {
                using (Form_Editar_Produto fp = new Form_Editar_Produto())
                {
                    fp.produtoId = produtoId;
                    fp.nome = nome;
                    fp.preco = preco;
                    fp.existencia = existencia;
                    fp.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (produtoId != null)
            {
                string funcao;
                db.getSingleValue("delete from tblProdutos where id = '" + produtoId + "'", out funcao, 0);
                MessageBox.Show("Registo eliminado com suceso!...", "Registo eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.OnLoad(e);
            }
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            using (Form_Registar_Produto fp = new Form_Registar_Produto())
            {
                
                fp.ShowDialog();
                 
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
