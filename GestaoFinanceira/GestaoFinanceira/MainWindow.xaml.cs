using GestaoFinanceira.Consumer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestaoFinanceira
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            APIConsumer.InitializeCliente();

            //GetTransactions();
            Login();
        }

        private async Task GetTransactions()
        {
            var transactions = await TransactionProcessor.GetTransactions(1);
        }
        
        private async Task Login()
        {
            var user = await UserProcessor.Login("otaner", "renato123");
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
