using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial_SebastianGomez
{
    /// <summary>
    /// Interaction logic for Empleado.xaml
    /// </summary>
    public partial class Empleado : Page
    {
        public Empleado()
        {
            InitializeComponent();

            cboxPanes.Items.Add("Aliñado");
            cboxPanes.Items.Add("No aliñado");
            cboxPanes.Items.Add("Especial");
        }
    }
}
