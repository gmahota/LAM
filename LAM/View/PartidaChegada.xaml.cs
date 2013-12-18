using LAM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAM.View
{
    /// <summary>
    /// Interaction logic for PartidaChegada.xaml
    /// </summary>
    public partial class PartidaChegada : UserControl
    {
        
        
        public PartidaChegada()
        {
            InitializeComponent();
            //Voos.Add(new voos ( ) {compania = "Airline",voo = "Fligth",destino ="Destination",
             //   partida="Departure",previsao="Expected",obs="Remark"});

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
