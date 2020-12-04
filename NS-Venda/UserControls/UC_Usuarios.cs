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

            textBox1.Text = usuarioId;
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
                db.getSingleValue("delete from tblUsuarios where id = '" +textBox1.Text + "'", out funcao, 0);
                MessageBox.Show("Registo eliminado com suceso!...", "Registo eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.OnLoad(e);
            }
        }
    }
}
