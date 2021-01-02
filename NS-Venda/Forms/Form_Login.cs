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
    public partial class Form_Login : Form
    {
        DbConnector db;
        public Form_Login()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                if (checkLogin())
                {
                    this.Alert("Success Alert", Form_Alert.enmType.Success);
                    using (Form_Dashboard fd = new Form_Dashboard())
                    {
                        string nomeUsuario = Properties.Settings.Default.NomeUsuario;
                        //Properties.Settings.Default.teste = nomeUsuario.ToString();
                        
                        fd.ShowDialog();
                    }
                }
            }

           
             
            
        }

        private bool checkLogin()
        {
            string nomeUsuario = db.getSingleValue("select NomeUsuario from tblUsuarios where NomeUsuario = '" + txtNomeUsuario.Text + "' and PalavraPasse = '" + txtPalavraPasse.Text + "'", out nomeUsuario, 0);
            if (nomeUsuario == null)
            {
                MessageBox.Show("Nome do usuário ou palavra passe está incorrecto", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isFormValid()
        {
            if (txtNomeUsuario.Text.ToString().Trim() == string.Empty || txtPalavraPasse.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Os campos precisam ser preenchidos", "Por favor, preencha todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
