using LAM.Model;
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
    public partial class TelaGestaoBalcao : MetroWindow
    {
        public event EventHandler<BalcaoUpdateEventArgs> updateBalcao;

        public TelaGestaoBalcao()
        {
            InitializeComponent();

            //updateBalcao = new EventHandler<BalcaoUpdateEventArgs>(;
        }

        internal void iniciarComponentes(int balcao)
        {
            voos.lerTv(balcao);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                voos.gravar();
                if(updateBalcao != null)
                    this.updateBalcao(this, new BalcaoUpdateEventArgs(voos.balcao));

            }
            catch 
            {
                MessageBox.Show("A tela " + voos.getTvNumber() +" do balcao " + voos.balcao + " não se encontra disponivel - por favor, contacte o administrador do sistema");
            }
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            voos.editar();
        }
    }
}
