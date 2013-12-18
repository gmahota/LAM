using LAM.Model;
using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace LAM.View
{
    /// <summary>
    /// Interaction logic for Voos.xaml
    /// </summary>
    public partial class VoosChegada : MetroWindow
    {
        //ObservableCollection<chekin> list = new ObservableCollection<chekin>();
        List<KeyValuePair<string, string>> imageslist;

        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
        static LAMEntities context = new LAMEntities();
        public VoosChegada()
        {
            imageslist =
            new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string,string>("LAM", @"/LAM;component/Resources/Logotipos/LAM.jpg"),
                new KeyValuePair<string,string>("SAA", @"/LAM;component/Resources/Logotipos/saa.jpg"),
            };

            InitializeComponent();
            //g.ItemsSource = list;

            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();

            //imageList.ItemsSource = images;
       
        }


        
        public void inicializarcomponentes()
        {

        }



        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            label2.Content = d.ToString("dd/MM/yyyy ")+  d.Hour + " : " + d.Minute + " : " + d.Second;
        }

        private void g_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cblcompanhias_Initialized(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            combo.Items.Clear();
            combo.ItemsSource = context.Companhia;
        }

    }
}
