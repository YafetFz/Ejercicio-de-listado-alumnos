using System;
using System.Collections.Generic;
using System.Text;

namespace Yafet_Flores_Listado_Alumnos
{
    public class Alumno
    {
        //Atributos
        private string nombre;
        private string apellido;
        private string fechaNacimiento;
        private int nota;

        //Encapsulamiento
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get{ return apellido; }
            set { apellido = value; }
        }

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        //Constructor
        public Alumno(string nombre, string apellido, string fechaNacimiento, int nota)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento=fechaNacimiento;
            this.nota = nota;
        } 
            
        
    }
}
