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
using OMB_Desktop.ViewModels;

namespace OMB_Desktop
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private ViewModels.LoginViewModel vm;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void MostrarLogin(object sender, RoutedEventArgs e)
    {
      
      Views.LoginUserControl loginControl = new Views.LoginUserControl();

      mainContent.Content = loginControl;

      loginControl.LoginOK += (o, user) => {
        mainContent.Content = null;
        //  user.Empleado.Persona.Nombres
      } ;
      
      //vm = new LoginViewModel();

    }
  }
}
