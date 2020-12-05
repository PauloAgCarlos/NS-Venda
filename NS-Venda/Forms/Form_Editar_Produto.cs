using SLRDbConnector;
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
    public partial class Form_Editar_Produto : Form
    {
        public string produtoId { get; set; }
        public string nome { get; set; }
        public string preco { get; set; }
        public string existencia { get; set; }


        DbConnector db;
        public Form_Editar_Produto()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void Form_Editar_Produto_Load(object sender, EventArgs e)
        {
            db.FillCombobox("select nome from tblProdutos", cmbCategoria);
            txtID.Text = produtoId;
            txtNome.Text = nome;
            txtPreco.Text = preco;
            txtExistencia.Text = existencia;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                inserirRegisto();
            }
        }

        private void inserirRegisto()
        {


            db.performCRUD("update tblProdutos set nome = '" + txtNome.Text + "', preco = '" + txtPreco.Text + "', existencia = '" + txtExistencia.Text + "' where id = "+produtoId);
            MessageBox.Show("Produto actualizado com sucesso!...", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();

        }

        private bool isFormValid()
        {
            if (txtNome.Text.Trim() == string.Empty
                || txtPreco.Text.Trim() == string.Empty
                || txtExistencia.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por valor, preencha todos os campos");
                return false;
            }

            else
                return true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void txtExistencia_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }
    }
}
