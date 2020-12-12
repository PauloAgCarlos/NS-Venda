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
    public partial class UC_Usuarios : UserControl
    {
      
        DbConnector db;
        public UC_Usuarios()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void UC_Usuarios_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from tblUsuarios", dataGridView1);
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private string usuarioId, nomeCompleto, nomeUsuario, palavraPasse, email, telefone, funcao, morada;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                usuarioId = item.Cells[0].Value.ToString();
                nomeCompleto = item.Cells[1].Value.ToString();
                nomeUsuario = item.Cells[2].Value.ToString();
                palavraPasse = item.Cells[3].Value.ToString();
                telefone = item.Cells[4].Value.ToString();
                email = item.Cells[5].Value.ToString();
                morada = item.Cells[6].Value.ToString();
                funcao = item.Cells[7].Value.ToString();

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuarioId != null)
            {
                using (Form_Editar_Usuario fu = new Form_Editar_Usuario())
                {
                    fu.UsuarioId = usuarioId;
                    fu.nomeCompleto = nomeCompleto;
                    fu.nomeUsuario = nomeUsuario;
                    fu.palavraPasse = palavraPasse;
                    fu.telefone = telefone;
                    fu.morada = morada;
                    fu.email = email;
                    fu.funcao = funcao;
                    fu.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (usuarioId != null)
            {
                string funcao;
                db.getSingleValue("delete from tblUsuarios where id = '" +usuarioId + "'", out funcao, 0);
                MessageBox.Show("Registo eliminado com suceso!...", "Registo eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.OnLoad(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                inserirRegisto();
            }
        }

        private void inserirRegisto()
        {


            db.performCRUD("insert into tblUsuarios (nomecompleto,nomeusuario,palavrapasse,morada, telefone, email, funcao) Values ('" + txtNomeCompleto.Text + "','" + txtNomeUsuario.Text + "','" + txtPalavraPasse.Text + "','" + txtMorada.Text + "','" + txtTelefone.Text + "','" + txtEmail.Text + "','" + cmbFuncao.SelectedItem.ToString() + "')");
            MessageBox.Show("Usuário adicionado com sucesso!...", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpar();

        }

        private bool isFormValid()
        {
            if (txtNomeCompleto.Text.Trim() == string.Empty
                || txtNomeUsuario.Text.Trim() == string.Empty
                || txtPalavraPasse.Text.Trim() == string.Empty
                || txtTelefone.Text.Trim() == string.Empty
                || txtMorada.Text.Trim() == string.Empty
                || txtEmail.Text.Trim() == string.Empty
                || cmbFuncao.SelectedItem == null
                )
            {
                MessageBox.Show("Por valor, preencha todos os campos");
                return false;
            }

            else
                return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpar();
        }
        public void limpar()
        {
            txtEmail.Clear();
            txtMorada.Clear();
            txtNomeCompleto.Clear();
            txtNomeUsuario.Clear();
            txtPalavraPasse.Clear();
            txtTelefone.Clear();
            cmbFuncao.SelectedItem = null;
        }
    }
}
