using NS_Venda.UserControls;
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
    public partial class Form_Editar_Usuario : Form
    {
        public string UsuarioId { get; set; }
        public string nomeCompleto { get; set; }
        public string nomeUsuario { get; set; }
        public string palavraPasse { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string morada { get; set; }
        public string funcao { get; set; }

        DbConnector db;
        public Form_Editar_Usuario()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void Form_Editar_Usuario_Load(object sender, EventArgs e)
        {
            db.FillCombobox("select funcao from tblUsuarios", cmbFuncao);
            txtNomeCompleto.Text = nomeCompleto;
            txtNomeUsuario.Text = nomeUsuario;
            txtPalavraPasse.Text = palavraPasse;
            txtTelefone.Text = telefone;
            txtEmail.Text = email;
            txtMorada.Text = morada;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string funcao;
            db.getSingleValue("select nomeCompleto from tblUsuarios where nomeCompleto = '" + cmbFuncao.SelectedItem.ToString() + "'", out funcao, 0);
            txtNomeUsuario.Text = funcao;
            
        }
    }
}
