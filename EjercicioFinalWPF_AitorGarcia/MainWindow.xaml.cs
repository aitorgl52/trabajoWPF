using EjercicioFinalWPF_AitorGarcia.dto;
using EjercicioFinalWPF_AitorGarcia.logica;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjercicioFinalWPF_AitorGarcia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private LogicaNegocio logicaNegocio;
        public MainWindow()
        {
            InitializeComponent();
            logicaNegocio= new LogicaNegocio();
            dataGridLibros.DataContext= logicaNegocio;
            this.DataContext = this;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DialogoLibro dialogoLibro = new DialogoLibro(logicaNegocio);
            dialogoLibro.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(dataGridLibros.SelectedIndex != -1) {
            Libro libro = (Libro)dataGridLibros.SelectedItem;
            DialogoLibro dialogoLibro = new DialogoLibro(logicaNegocio,(Libro) libro.Clone(), dataGridLibros.SelectedIndex);
                dialogoLibro.Show();
            }

            
        }
    }
}
