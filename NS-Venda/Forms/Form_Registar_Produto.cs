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
    public partial class Form_Registar_Produto : Form
    {
        
        DbConnector db;
        public Form_Registar_Produto()
        {
            InitializeComponent();
            db = new DbConnector();
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
            
                
                db.performCRUD("insert into tblProdutos (nome,preco,existencia) Values ('" + txtNome.Text + "','" + txtPreco.Text + "','" + txtExistencia.Text+"')");
                MessageBox.Show("Produto adicionado com sucesso!...", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
