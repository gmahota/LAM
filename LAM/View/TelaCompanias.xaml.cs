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

namespace LAM.View
{
    /// <summary>
    /// Interaction logic for TelaCompanias.xaml
    /// </summary>
    public partial class TelaCompanias : Window
    {
        public TelaCompanias()
        {
            InitializeComponent();
        }

        private void GestaoMonitores_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            voos.BindData();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void add_click(object sender, RoutedEventArgs e)
        {
            Compania f = new Compania();
            f.Owner = this;

            f.ShowDialog();
        }


        private void edit_Click(object sender, RoutedEventArgs e)
        {
            Compania f = new Compania();
            f.Owner = this;

            f.ShowDialog();
        }

        private void voos_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
