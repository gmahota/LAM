using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace LAM.View
{
    /// <summary>
    /// Interaction logic for ctrlVoos.xaml
    /// </summary>
    public partial class ctrlBalcao1 : UserControl
    {
        public ctrlBalcao1()
        {
            InitializeComponent();
        }

        public void lerTv(int balcao) 
        {
            //XmlDocument doc = new XmlDocument();
            XDocument doc = XDocument.Load("../../Resources/voos.xml");

            
            //doc.Load();


            var balcoes = doc.Descendants("balcao");

            foreach (var b in balcoes) 
            {
                var c = b.FirstNode as XElement;
                if (c.Value == balcao+"") 
                {
                    var caminhologo = (c.NextNode as XElement);
                    var voo = (caminhologo.NextNode as XElement);
                    var destino = (voo.NextNode as XElement);
                    var classe = (destino.NextNode as XElement);

                    loadComponetes(caminhologo.Value, voo.Value, destino.Value, classe.Value);
                }
            }

        }

        public void loadComponetes(string caminhologo, string voo, string destino, string classe)
        {
            lblClasse.Content = classe;
            lblVoo.Content = voo;
            lblDestino.Content = destino;

            //Image finalImage = new Image();
            //finalImage.Width = 80;
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/LAM;component/Resources/Logotipos/" + caminhologo, UriKind.RelativeOrAbsolute);
            logo.EndInit();

            imgCompania.Source = logo;
        }

        #region accoes
        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            txtVoo.Visibility = Visibility.Visible;
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            txtClasse.Visibility = Visibility.Visible;
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            txtDestino.Visibility = Visibility.Visible;
        }

        private void Image_MouseDown_img(object sender, MouseButtonEventArgs e)
        {
            cblCompania.Visibility = Visibility.Visible;
        }

        private void txtVoo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lblVoo.Content = txtVoo.Text;
                txtVoo.Visibility = Visibility.Hidden;
            }
        }

        private void txtDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lblDestino.Content = txtDestino.Text;
                txtDestino.Visibility = Visibility.Hidden;
            }
        }

        private void txtClasse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lblClasse.Content = txtClasse.Text;
                txtClasse.Visibility = Visibility.Hidden;
            }
        }

        //cblCompania_KeyDown
        private void cblCompania_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                XmlElement elementos = (XmlElement)cblCompania.SelectedItem;

                BitmapImage logo = new BitmapImage();
                logo.BeginInit();
                logo.UriSource = new Uri(elementos.GetAttribute("icon"), UriKind.Relative);
                logo.EndInit();

                //string value = typeItem.Content.ToString();
                //MessageBox.Show(value);
                if (e.Key == Key.Enter)
                {
                    imgCompania.Source = logo;
                    cblCompania.Visibility = Visibility.Hidden;
                }
            }
            catch { }
            
        }

    }
        #endregion
}
