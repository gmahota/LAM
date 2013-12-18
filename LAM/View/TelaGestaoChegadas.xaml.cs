using MahApps.Metro.Controls;
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
    /// Interaction logic for TelaGestaoPartidas.xaml
    /// </summary>
    public partial class TelaGestaoChegadas : MetroWindow
    {
        static crtchegadas chegada = new crtchegadas();
        public TelaGestaoChegadas()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            voo.novaLinha();

            //DataGridRow row = voo
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
          var selectedindex = chegada.g.SelectedItem ;
           if (selectedindex == null)
               return;
            chegada.g.Items.Remove(selectedindex);
            
        }

        private void crtchegadas1_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            chegada.g.Items.Refresh();

        }
    }
}
