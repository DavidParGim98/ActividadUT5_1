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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Actividad1_UT5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Plato> platos = Plato.GetSamples("assets/");
        ObservableCollection<string> tipoComida = new ObservableCollection<string>();        

        public MainWindow()
        {
            InitializeComponent();

            tipoComida.Add("China");
            tipoComida.Add("Americana");
            tipoComida.Add("Mexicana");

            tipoCom.ItemsSource = tipoComida;

            Comidas.DataContext = platos;
        }

        private void ListBoxItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
