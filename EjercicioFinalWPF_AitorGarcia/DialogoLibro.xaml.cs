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
using System.Windows.Shapes;

namespace EjercicioFinalWPF_AitorGarcia
{
    /// <summary>
    /// Lógica de interacción para DialogoLibro.xaml
    /// </summary>
    public partial class DialogoLibro : Window
    {
        public Libro libro;
        private int posicion;
        private LogicaNegocio logicaNegocio;
        private Boolean modificar;
        public DialogoLibro(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio= logicaNegocio;
            libro = new Libro();
            this.DataContext= libro;
            modificar= false;
        }

        public DialogoLibro(LogicaNegocio logicaNegocio, Libro libroModificar, int posicion)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.libro = libroModificar; 
            this.posicion = posicion;
            this.DataContext = libro;
            modificar = true;
        }

        private void buttonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if(modificar) {
                logicaNegocio.modificarLibro(libro, posicion);
                this.Close();
            }
            else
            {
                logicaNegocio.añadirLibro(libro);
                this.Close();
            }
            
        }
    }
}
