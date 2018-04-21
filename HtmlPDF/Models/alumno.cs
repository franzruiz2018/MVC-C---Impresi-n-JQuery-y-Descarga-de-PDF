using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlPDF.Models
{
    public class Alumno
    {
        public int id { get; set; }
        public string name { get; set; }
        public int dni { get; set; }
        public string direccion { get; set; }
        public DateTime fechaRegistro { get; set; }



        public List<Alumno> ListaAlumnos()
        {
           List<Alumno> _ListaAlumnos=new   List<Alumno>();

           Alumno alumno1 = new Alumno();
           alumno1.id = 1;
           alumno1.name = "Franz";
           alumno1.dni = 12345678;
           alumno1.direccion = "Lima";
           alumno1.fechaRegistro = Convert.ToDateTime("01/02/2018 08:00:00");
           _ListaAlumnos.Add(alumno1);

           Alumno alumno2 = new Alumno();
           alumno2.id = 2;
           alumno2.name = "Milka";
           alumno2.dni = 12345678;
           alumno2.direccion = "Lima";
           alumno2.fechaRegistro = Convert.ToDateTime("01/02/2018 08:00:00");
           _ListaAlumnos.Add(alumno2);

           Alumno alumno3 = new Alumno();
           alumno3.id = 3;
           alumno3.name = "Carmen";
           alumno3.dni = 12345678;
           alumno3.direccion = "Lima";
           alumno3.fechaRegistro = Convert.ToDateTime("01/02/2018 08:00:00");
           _ListaAlumnos.Add(alumno3);

           Alumno alumno4 = new Alumno();
           alumno4.id = 4;
           alumno4.name = "Harold";
           alumno4.dni = 12345678;
           alumno4.direccion = "Lima";
           alumno4.fechaRegistro = Convert.ToDateTime("01/02/2018 08:00:00");
           _ListaAlumnos.Add(alumno4);
          
           return _ListaAlumnos;

        }

       
    }
}