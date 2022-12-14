using EjercicioFinalWPF_AitorGarcia.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinalWPF_AitorGarcia.logica
{
    public class LogicaNegocio
    {

        public ObservableCollection<Libro> listaLibros { get; set; }

        public LogicaNegocio() {
        
        listaLibros= new ObservableCollection<Libro>();
        listaLibros.Add(new Libro("Un titulo", "Autor", DateTime.Now));
            
        }

        public void añadirLibro(Libro libro)
        {
            listaLibros.Add(libro);
        }

        public void modificarLibro(Libro libro, int posicion)
        {
            listaLibros[posicion] = libro;
            
        }

    }
}
