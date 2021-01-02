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
    public partial class UC_Entradas : UserControl
    {
        DbConnector db;
        public UC_Entradas()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExistencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string valExistencia = "";
            if (txtNome.Text == "" || txtQtd.Text == "" || txtFornecedor.Text == "")
            {
                MessageBox.Show("Preecha todos os campos", "Preencher Campos!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                valExistencia = "select existencia from tblProdutos where nome like '%" + txtNome.Text + "%'";
                int ex = Convert.ToInt32(existencia);
                ex = ex + Convert.ToInt32(txtQtd.Text);
                db.performCRUD("insert into tblEntradas (produto_id,quantidade) Values ('" + txtID.Text + "','" + txtQtd.Text + "')");
                db.performCRUD("update tblProdutos set existencia = '" + ex + "' where id = " + produtoId);
                
                MessageBox.Show("Produto adicionado com sucesso!...", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtID.Text = "";
                txtNome.Text = "";
                txtPreco.Text = "";
                txtExistencia.Text = "";
                txtQtd.Text = "";

            }
        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {
            string query = "";

            if (txtNome.Text != null)
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

        private void UC_Entradas_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from tblEntradas", dataGridView1);
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

        private void txtQtd_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
