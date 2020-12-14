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
    public partial class UC_Fornecedores : UserControl
    {
        DbConnector db;
        public UC_Fornecedores()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void UC_Fornecedores_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from tblFornecedores", dataGridView1);
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            using (Form_Registar_Fornecedor ff = new Form_Registar_Fornecedor())
            {

                ff.ShowDialog();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (Form_Editar_Fornecedor ff = new Form_Editar_Fornecedor())
            {

                ff.ShowDialog();

            }
        }
    }
}
