using LAM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Xml;
using System.Xml.Linq;

namespace LAM.View
{
    /// <summary>
    /// Interaction logic for crtchegadas.xaml
    /// </summary>
    public partial class crtchegadas1 : UserControl
    {
        //ObservableCollection<chekin> list = new ObservableCollection<chekin>();
        List<KeyValuePair<string, string>> imageslist;
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();

        public crtchegadas1()
        {
            InitializeComponent();

            BindGridUsingList();

            //g.ItemsSource = list;

            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void BindGridUsingDataSet()
        {
            string sampleXmlFile = @"/LAM;component/Resources/chegada.xml";
            
            
            
            
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(sampleXmlFile);
            DataView dataView = new DataView(dataSet.Tables[0]);
            dataGrid1.ItemsSource = dataView;
        }

        private void BindGridUsingList()
        {
            /*
            string sampleXmlFile = @"/LAM;component/Resources/chegada.xml";
            XElement xElement = XElement.Load(sampleXmlFile);
            IEnumerable<XElement> chegadas = xElement.Elements();
            List<Chegada> lstChegadas = new List<Chegada>();
            
            // Read the entire XML
            foreach (var chegada in chegadas)
            {
                lstChegadas.Add(new Chegada
                {
                    chegada = chegada.Element("chegada").Value, 
                    compania = chegada.Element("compania").Value, 
                    destino = chegada.Element("destino").Value,
                    obs = chegada.Element("Obs").Value,
                    previsao = chegada.Element("previsao").Value
                });
            }

            dataGrid1.ItemsSource = lstChegadas;*/
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

        internal void novaLinha()
        {
            
        }

        private void DataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Cancel)
            {
                e.Cancel = false;
                return;

            }

            if (e.EditAction == DataGridEditAction.Commit)
            {
                DataGridRow dgr = e.Row;
               //XmlElement xe = Chegada;
            }
                
        }
    }
}
