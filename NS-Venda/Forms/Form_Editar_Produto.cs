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
    }
}
