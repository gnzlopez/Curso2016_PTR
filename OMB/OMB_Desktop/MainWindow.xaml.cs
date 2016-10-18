﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OMB_Desktop
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void MostrarLogin(object sender, RoutedEventArgs e)
    {
      
      Views.LoginControl loginControl = new Views.LoginControl();

      mainContent.Content = loginControl;

      loginControl.LoginOK += (o, user) => {
        mainContent.Content = null;
        //
        //  setear el usuario para poder mostrarlo en la UI
      } ;
    }
  }
}
