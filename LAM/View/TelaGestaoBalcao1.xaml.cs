﻿using MahApps.Metro.Controls;
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
    public partial class TelaGestaoBalcao1 : MetroWindow
    {
        public TelaGestaoBalcao1()
        {
            InitializeComponent();
        }

        public void iniciarComponentes(int balcao)
        {
            voos.lerTv(balcao);
        }
    }
}
