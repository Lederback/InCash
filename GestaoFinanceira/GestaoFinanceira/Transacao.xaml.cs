using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GestaoFinanceira
{
    /// <summary>
    /// Lógica interna para Transacao.xaml
    /// </summary>
    public partial class Transacao : Window
    {
        public Transacao()
        {
            InitializeComponent();
        }

        private void MenuButton_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Button).Foreground = Brushes.Black;
        }

        private void MenuButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FFFFFF");
            Brush brush = new SolidColorBrush(color);
            (sender as Button).Foreground = brush;
        }
    }
}
