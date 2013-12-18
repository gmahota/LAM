using LAM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
    /// Interaction logic for Companias.xaml
    /// </summary>
    public partial class Companias : UserControl
    {
        ObservableCollection<Companhia> list;
        static LAMEntities context = new LAMEntities();

        public Companias()
        {
            InitializeComponent();
            BindData();
            
        }

        public void BindData()
        {
        
            list = new ObservableCollection<Companhia>(context.Companhia.ToList());

            list.CollectionChanged += CollectionChanged;
            g.ItemsSource = list;
            //g.DataContext = list;
            g.CanUserAddRows=true;
        }

        private void CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                foreach (Companhia cheg in e.NewItems)
                    context.Companhia.Add(cheg);

            else if (e.Action == NotifyCollectionChangedAction.Remove)
                foreach (Companhia cheg in e.OldItems)
                    context.Companhia.Remove(cheg);
            BindData();
        }

        
    }
}
