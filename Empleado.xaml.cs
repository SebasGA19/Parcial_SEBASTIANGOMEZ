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

            cboxPanes.Items.Add("aliñado");
            cboxPanes.Items.Add("no aliñado");
            cboxPanes.Items.Add("especial");
            
        }

        private void btnPanes_Click(object sender, RoutedEventArgs e)
        {
            if (sldPanes.Value != 0)
            {
                if (cboxPanes.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un tipo de pan");
                }

                else if (cboxPanes.SelectedItem.ToString() == "aliñado")
                {
                    lboxPanes.Items.Add(string.Format("{0} | {1} | {2}", cboxPanes.SelectedItem, 1000 * sldPanes.Value, sldPanes.Value));
                    
                }

                else if (cboxPanes.SelectedItem.ToString() == "no aliñado")
                {
                    lboxPanes.Items.Add(string.Format("{0} | {1} | {2}", cboxPanes.SelectedItem, 500 * sldPanes.Value, sldPanes.Value));
                }

                else if (cboxPanes.SelectedItem.ToString() == "especial")
                {
                    lboxPanes.Items.Add(string.Format("{0} | {1} | {2}", cboxPanes.SelectedItem, 2000 * sldPanes.Value, sldPanes.Value));
                }
            }
        }

        private void btnVender_Click(object sender, RoutedEventArgs e)
        {
            if (lboxPanes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un item");
            }
            else if (txtNombre.Text == "" || txtCedula.Text == "")
            {
                MessageBox.Show("Ingrese Credenciales");
            }
            else
            {
                string itemBox = lboxPanes.SelectedItem.ToString();
                string hora = DateTime.Now.ToString("hh:mm:ss tt");
                string comprador = txtNombre.Text;
                string cedula = txtCedula.Text;
                blkProductos.Text += string.Format("{0} | {1} | {2} | {3}", itemBox, comprador, cedula, hora) +"\n";
            }
        }
    }
}
