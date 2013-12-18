using LAM.Model;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LAM.View
{
    /// <summary>
    /// Interaction logic for VoosPartida.xaml
    /// </summary>
    public partial class VoosPartida : MetroWindow
    {
       // ObservableCollection<chekin> list = new ObservableCollection<chekin>();
        List<KeyValuePair<string, string>> imageslist;
        LAMEntities context = new LAMEntities();
        //Adding Companies content to combobox
        List<Companhia> companhias = new List<Companhia>();
        
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();

        public VoosPartida()
        {
          

            imageslist =
            new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string,string>("LAM", @"/LAM;component/Resources/Logotipos/LAM.jpg"),
                new KeyValuePair<string,string>("SAA", @"/LAM;component/Resources/Logotipos/saa.jpg"),
            };

            InitializeComponent();

            g.DataContext = context.Chegada ;
            g.Items.Add("");
            companhias.AddRange(context.Companhia.ToList());


            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
           
        }

        public void inicializarcomponentes()
        {
          
        }



        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            label2.Content = d.ToString("dd/MM/yyyy ") + d.Hour + " : " + d.Minute + " : " + d.Second;
        }

        private void g_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //var elementos = g.DataContext.GetType();
            //elementos.Document.Save();

            //XmlDataProvider myXmlDataProvider = Resources["Voos"] as XmlDataProvider;

            //var myXmlDataProvider = g.DataContext.GetType();
          //  myXmlDataProvider.Document.Save("\resources\voos.xml");

        }
    }
}
