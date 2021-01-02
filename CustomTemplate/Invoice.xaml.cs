using System;
using System.Windows.Controls;
using System.Windows.Printing;

namespace CustomTemplate
{
    public partial class Invoice : UserControl
    {
        PrintDocument printInvoice = new PrintDocument();
        public Invoice()
        {
            InitializeComponent();

            //tbData.Text = DateTime.Today.ToShortDateString();
            tbData.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
            //tbHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnPrint_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            printInvoice.PrintPage +=
                new EventHandler<PrintPageEventArgs>(printInvoice_PrintPage);
            printInvoice.Print(String.Format("Invoice Date: {0}", DateTime.Today.ToShortDateString()));
        }

        void printInvoice_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageVisual = LayoutRoot;
        }
    }
}