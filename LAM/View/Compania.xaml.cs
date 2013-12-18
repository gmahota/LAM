using LAM.Model;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LAM.View
{
    /// <summary>
    /// Interaction logic for Compania.xaml
    /// </summary>
    public partial class Compania : Window
    {

        private LAMEntities context = new LAMEntities();
        string caminhoImg;
        public Compania()
        {
            InitializeComponent();
        }

        public void buscarCompanhia(int id) 
        {
            var comp = context.Companhia.Find(id);

            txtnome.Text = comp.Nome;

        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (*.png)|*.png";
            op.ShowDialog();            
            imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
            caminhoImg = op.FileName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FileStream Stream = new FileStream(caminhoImg, FileMode.Open, FileAccess.Read);
                StreamReader Reader = new StreamReader(Stream);
                Byte[] ImgData = new Byte[Stream.Length - 1];
                Stream.Read(ImgData, 0, (int)Stream.Length - 1);
                
                Companhia compania = new Companhia();
                compania.Contacto = txtcontacto.Text;
                compania.Nome = txtnome.Text;
                compania.Icon = ImgData;
                compania.Sigla = txtsigla.Text;

                context.Companhia.Add(compania);

                context.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Gravado Com Sucesso");
            }
            catch
            {
                Companhia compania = new Companhia();
                compania.Contacto = txtcontacto.Text;
                compania.Nome = txtnome.Text;
                compania.Sigla = txtsigla.Text;
                //compania.Icon = ImgData;

                context.Companhia.Add(compania);
                context.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Gravado Com Sucesso");
            }
            
              //  var encoder = new PngBitmapEncoder();
              //  encoder.Frames.Add(BitmapFrame.Create((BitmapSource)imgPhoto.Source));
              //  encoder.Save(@"/LAM;component/Resources/Logotipos/");

            
        }
    }
}
