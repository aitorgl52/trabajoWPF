using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinalWPF_AitorGarcia.dto
{
    public class Libro : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {

        private String titulo;
        public String Titulo {
            get { return titulo; } 

            set { titulo= value; 
            this.PropertyChanged(this, new PropertyChangedEventArgs("Titulo"));
            }
        }

        private String autor;
        public String Autor
        {
            get { return autor; }

            set
            {
                autor = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Autor"));
            }
        }

        private DateTime fechaEntrada;
        public DateTime FechaEntrada
        {
            get { return fechaEntrada; }

            set
            {
                fechaEntrada = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaEntrada"));
            }
        }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string result = "";
                if(columnName == "Titulo")
                {
                    if(string.IsNullOrEmpty(titulo))
                    {
                        result = "Introduce el titulo";
                    }
                    if(columnName == "Autor")
                    {
                        if(string.IsNullOrEmpty(autor))
                        {
                            result = "Deba introducir el autor";
                        }
                        return result;
                    }
                }
                return result;
            }
        }

        public Libro(string titulo, string autor, DateTime fechaEntrada)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fechaEntrada = fechaEntrada;
        }
        public Libro()
        {
            this.fechaEntrada= DateTime.Now; 
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            return this.MemberwiseClone();
        }



    }
}
