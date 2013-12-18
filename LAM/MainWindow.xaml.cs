using LAM.Model;
using LAM.View;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAM
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        EnventoBalcao evento = null;

        private double LastHeight, LastWidth;
        private System.Windows.WindowState LastState;

        private int tv = 0;

        public MainWindow()
        {
            
            InitializeComponent();

            LastHeight = Height;
            LastWidth = Width;
            LastState = WindowState;

            Topmost = true;
            Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            Top = 0;
            Left = 0;
            WindowState = System.Windows.WindowState.Normal;
            //WindowStyle = WindowStyle.None;
            ResizeMode = System.Windows.ResizeMode.NoResize;
            

            //this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            actualizar();

            evento = new EnventoBalcao();

            evento.balcaoReached += evento_balcaoReached; 
        }

        private void evento_balcaoReached(object sender, BalcaoUpdateEventArgs e)
        {
            switch (e.getBalcao) 
            {
                case 1: voo1.lerTv(1); break;
                case 2: voo1.lerTv(2); break;
                case 3: voo1.lerTv(3); break;
                case 4: voo1.lerTv(4); break;
                case 5: voo1.lerTv(5); break;
            }
        }

        public void actualizar() 
        {
            voo1.lerTv(1);
            voo2.lerTv(2);
            voo3.lerTv(3);
            voo4.lerTv(4);
            voo5.lerTv(5);
        }
        
        private void onclick() 
        {
            switch (tv)
            {
                case 1:

                    TelaGestaoPartidas form1 = new TelaGestaoPartidas();

                    form1.Left = this.Left;
                    form1.Top = this.Top;
                    form1.Width = this.Width;
                    form1.Height = this.Height;
                    form1.WindowState = this.WindowState;

                    form1.WindowStartupLocation = WindowStartupLocation.Manual;
                    form1.Owner = this;
                    form1.ShowInTaskbar = false;
                    form1.Show();


                    break;
                case 2:
                    TelaGestaoChegadas form2 = new TelaGestaoChegadas();

                    form2.Left = this.Left;
                    form2.Top = this.Top;
                    form2.Width = this.Width;
                    form2.Height = this.Height;
                    form2.WindowState = this.WindowState;

                    form2.WindowStartupLocation = WindowStartupLocation.Manual;
                    form2.Owner = this;
                    form2.ShowInTaskbar = false;

                    form2.Show();



                    break;
                case 3:
                    
                    TelaGestaoBalcao form3 = new TelaGestaoBalcao();

                    form3.updateBalcao += form3_updateBalcao;

                    form3.iniciarComponentes(1);

                    form3.Left = this.Left;
                    form3.Top = this.Top;
                    form3.Width = this.Width;
                    form3.Height = this.Height;
                    form3.WindowState = this.WindowState;

                    form3.WindowStartupLocation = WindowStartupLocation.Manual;
                    form3.Owner = this;

                    form3.ShowInTaskbar = false;



                    form3.Show();


                    break;
                case 4:
                   
                    TelaGestaoBalcao form4 = new TelaGestaoBalcao();

                    form4.iniciarComponentes(2);


                    form4.Left = this.Left;
                    form4.Top = this.Top;
                    form4.Width = this.Width;
                    form4.Height = this.Height;
                    form4.WindowState = this.WindowState;

                    form4.WindowStartupLocation = WindowStartupLocation.Manual;
                    form4.Owner = this;
                    form4.ShowInTaskbar = false;
                    form4.Show();

                    break;
                case 5:

                    TelaGestaoBalcao form5 = new TelaGestaoBalcao();

                    form5.Left = this.Left;
                    form5.Top = this.Top;
                    form5.Width = this.Width;
                    form5.Height = this.Height;
                    form5.WindowState = this.WindowState;

                    form5.iniciarComponentes(3);

                    form5.WindowStartupLocation = WindowStartupLocation.Manual;
                    form5.Owner = this;
                    form5.ShowInTaskbar = false;
                    form5.Show();



                    break;
                case 6:
                    
                    TelaGestaoBalcao form6 = new TelaGestaoBalcao();

                    form6.Left = this.Left;
                    form6.Top = this.Top;
                    form6.Width = this.Width;
                    form6.Height = this.Height;
                    form6.WindowState = this.WindowState;

                    form6.iniciarComponentes(4);


                    form6.WindowStartupLocation = WindowStartupLocation.Manual;
                    form6.Owner = this;
                    form6.ShowInTaskbar = false;
                    form6.Show();

                    break;
                case 7:
                    
                    TelaGestaoBalcao form7 = new TelaGestaoBalcao();

                    form7.Left = this.Left;
                    form7.Top = this.Top;
                    form7.Width = this.Width;
                    form7.Height = this.Height;
                    form7.WindowState = this.WindowState;

                    form7.iniciarComponentes(5);

                    form7.WindowStartupLocation = WindowStartupLocation.Manual;
                    form7.Owner = this;
                    form7.ShowInTaskbar = false;

                    form7.Show();


                    break;
            }
            
            
                        
        }

        void form3_updateBalcao(object sender, BalcaoUpdateEventArgs e)
        {
            evento_balcaoReached(sender, e);
        }

        #region image_mousedown

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            tv = 1;
            onclick();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            tv = 2;
            onclick();
        }
        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            tv = 4; 
            onclick();
        }
        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            tv = 5;
            onclick();
        }
        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            tv = 3;
            onclick();
        }
        private void Image_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            tv = 6;
            onclick();
        }
        private void Image_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
            tv = 7;
            onclick();
        }

        #endregion

        private void inicializartelas()
        {
            var allScreens = System.Windows.Forms.Screen.AllScreens.ToList();

            var locationScreen = allScreens.SingleOrDefault(s => this.Left >= s.WorkingArea.Left && this.Left < s.WorkingArea.Right);

            int tv = 0;
            foreach (var tela in allScreens)
            {
                switch (tv)
                {
                    case 1:
                        
                        var tela1 = tela;
                        TelaPartida form1 = new TelaPartida();

                        form1.Left = tela1.WorkingArea.Left;
                        form1.Top = tela1.WorkingArea.Top;
                        form1.Width = tela1.WorkingArea.Width;
                        form1.Height = tela1.WorkingArea.Height;
                        form1.WindowState = WindowState.Normal;

                        form1.WindowStartupLocation = WindowStartupLocation.Manual;
                        form1.Owner = this;
                        form1.ShowInTaskbar = false;
                        form1.Show();


                        break;
                    case 2:
                        var tela2 = tela;

                        TelaChegada form2 = new TelaChegada();

                        form2.Left = tela2.WorkingArea.Left;
                        form2.Top = tela2.WorkingArea.Top;
                        form2.Width = tela2.WorkingArea.Width;
                        form2.Height = tela2.WorkingArea.Height;
                        form2.WindowState = WindowState.Normal;

                        form2.WindowStartupLocation = WindowStartupLocation.Manual;
                        form2.Owner = this;
                        form2.ShowInTaskbar = false;

                        form2.Show();



                        break;
                    case 3:
                        var tela3 = tela;

                        //JanelaClasse form3 = new JanelaClasse();
                        //form3.loadComponetes("saa.gif", "TM2120", "JOHANNESBURG", "");

                        TelaBalcao form3 = new TelaBalcao();

                        form3.iniciarComponentes(1);

                        form3.Left = tela3.WorkingArea.Left;
                        form3.Top = tela3.WorkingArea.Top;
                        form3.Width = tela3.WorkingArea.Width;
                        form3.Height = tela3.WorkingArea.Height;
                        form3.WindowState = WindowState.Normal;

                        form3.WindowStartupLocation = WindowStartupLocation.Manual;
                        form3.Owner = this;
                        form3.ShowInTaskbar = false;

                        form3.Show();


                        break;
                    case 4:
                        var tela4 = tela;

                        //JanelaClasse form4 = new JanelaClasse();
                        //form4.loadComponetes("saa.gif", "TM2120", "JOHANNESBURG", "");

                        TelaBalcao form4 = new TelaBalcao();

                        form4.iniciarComponentes(2);

                        form4.Left = tela4.WorkingArea.Left;
                        form4.Top = tela4.WorkingArea.Top;
                        form4.Width = tela4.WorkingArea.Width;
                        form4.Height = tela4.WorkingArea.Height;
                        form4.WindowState = WindowState.Normal;

                        form4.WindowStartupLocation = WindowStartupLocation.Manual;
                        form4.Owner = this;
                        form4.ShowInTaskbar = false;
                        form4.Show();

                        break;
                    case 5:
                        var tela5 = tela;

                        //JanelaClasse form5 = new JanelaClasse();
                        //form5.loadComponetes("saa.gif", "TM2120", "JOHANNESBURG", "");

                        TelaBalcao form5 = new TelaBalcao();

                        form5.iniciarComponentes(3);

                        form5.Left = tela5.WorkingArea.Left;
                        form5.Top = tela5.WorkingArea.Top;
                        form5.Width = tela5.WorkingArea.Width;
                        form5.Height = tela5.WorkingArea.Height;
                        form5.WindowState = WindowState.Normal;

                        form5.WindowStartupLocation = WindowStartupLocation.Manual;
                        form5.Owner = this;
                        form5.ShowInTaskbar = false;
                        form5.Show();



                        break;
                    case 6:
                        var tela6 = tela;

                        //JanelaClasse form6 = new JanelaClasse();
                        //form6.loadComponetes("saa.gif", "TM2120", "JOHANNESBURG", "");

                        TelaBalcao form6 = new TelaBalcao();

                        form6.iniciarComponentes(4);


                        form6.Left = tela6.WorkingArea.Left;
                        form6.Top = tela6.WorkingArea.Top;
                        form6.Width = tela6.WorkingArea.Width;
                        form6.Height = tela6.WorkingArea.Height;
                        form6.WindowState = WindowState.Normal;

                        form6.WindowStartupLocation = WindowStartupLocation.Manual;
                        form6.Owner = this;
                        form6.ShowInTaskbar = false;
                        form6.Show();

                        break;
                    case 7:
                        var tela7 = tela;

                        TelaBalcao form7 = new TelaBalcao();

                        form7.iniciarComponentes(5);

                        form7.Left = tela7.WorkingArea.Left;
                        form7.Top = tela7.WorkingArea.Top;
                        form7.Width = tela7.WorkingArea.Width;
                        form7.Height = tela7.WorkingArea.Height;
                        form7.WindowState = WindowState.Normal;

                        form7.WindowStartupLocation = WindowStartupLocation.Manual;
                        form7.Owner = this;
                        form7.ShowInTaskbar = false;

                        form7.Show();


                        break;
                }
                tv++;
                
            
            }

                
        }

        private void ctrlVoos_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void GestaoMonitores_Click(object sender, RoutedEventArgs e)
        {
            TelasTeste f = new TelasTeste();
            f.Owner = this;

            f.ShowDialog();
            //f.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            TelaCompanias f = new TelaCompanias();
            f.Owner = this;

            f.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            actualizar();
            inicializartelas();
        }

        private void MetroWindow_PreviewDrop(object sender, System.Windows.DragEventArgs e)
        {

        }

        private void ctrlPartidas_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();            
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string sMessageBoxText = "Deseja terminar a aplicação?";
            string sCaption = "Terminar Aplicação";

            MessageBoxButton btnMessageBox = MessageBoxButton.YesNoCancel;
            MessageBoxImage icnMessageBox = MessageBoxImage.Warning;

            MessageBoxResult rsltMessageBox = System.Windows.MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);

            switch (rsltMessageBox)
            {
                case MessageBoxResult.Yes:
                    
                    break;

                case MessageBoxResult.No:
                    e.Cancel = true; break;

                case MessageBoxResult.Cancel:
                    e.Cancel = true;break;
            }

            
        }

    }
}
