using LAM.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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

namespace LAM.View
{
    /// <summary>
    /// Interaction logic for crtchegadas.xaml
    /// </summary>
    public partial class crtchegadas : UserControl
    {

        List<KeyValuePair<string, string>> imageslist;
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
#region Special Code
        int controlItemIndex = -1;
        ObservableCollection<Chegada> list;
        ObservableCollection<Companhia> companhias;
        static LAMEntities context = new LAMEntities();
        Chegada chegada;
#endregion 

        public static List<Chegada> cheg
        {
            get
            {
                if (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv")
                    return new List<Chegada>();

                return context.Chegada.ToList();
            }
        }


        public crtchegadas()
        {
            InitializeComponent();

            //list = new ObservableCollection<Chegada>(context.Chegada.ToList());
            BindData();
            //g.ItemsSource = list;

            lbltitulo.Foreground = new SolidColorBrush(Colors.White);
            label2.Foreground = new SolidColorBrush(Colors.White);

            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void BindData()
        {
            //var dataSource = new ObservableCollection<ImapHost>(context.Car);
            list = new ObservableCollection<Chegada>(context.Chegada.ToList());
            companhias = new ObservableCollection<Companhia>(context.Companhia.ToList());
            list.CollectionChanged += CollectionChanged;
            g.ItemsSource = list;
            //g.DataContext = list;
        }

        private void CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                foreach (Chegada cheg in e.NewItems)
                    context.Chegada.Add(cheg);

            else if (e.Action == NotifyCollectionChangedAction.Remove)
                foreach (Chegada cheg in e.OldItems)
                    context.Chegada.Remove(cheg);
            //BindData();
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

            SaveChanges();
        }

        private void cblInternalComp_Initialized(object sender, EventArgs e)
        {
            try { 
            tempcombo= (FrameworkElement) sender as   ComboBox;
            tempcombo.Items.Clear();
            tempcombo.ItemsSource = companhias;
            if (controlItemIndex  < g.Items.Count)
            {
               
                controlItemIndex++;
                
            }
            var chegada = (Chegada)g.Items.GetItemAt(controlItemIndex) ;
            if (chegada.Companhia != null && chegada.Companhia>0)
            {
                var companhia = companhias.Single(x => x.Id == chegada.Companhia);

                tempcombo.SelectedItem = companhia;
            }
            else {

                tempcombo.SelectedIndex = -1;
            }
        
    }catch(Exception ex){}
        }
        public void SaveChanges() {
           

              context.SaveChanges();
              
        
        }
        public ComboBox tempcombo { get; set; }

        private void clInternalComp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
               chegada =  g.SelectedItem as Chegada;

                if (chegada == null)
                    chegada= new Chegada();
                var combo = (ComboBox)sender;
               var companhia = (Companhia)combo.SelectedItem;
                
                if (companhia == null)
                    return;
               chegada.Companhia1 = companhia;
               chegada.Companhia = companhia.Id;
               g.SelectedItem = chegada;
               // 
              
            }

            catch (NullReferenceException nex) {

               // MessageBox.Show(nex.Message);
           
            }
            
            
            
        }
    }
}
