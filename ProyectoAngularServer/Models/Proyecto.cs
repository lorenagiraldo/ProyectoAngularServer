using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoAngularServer.Models
{
    public class Proyecto
    {
        public String titulo {get; set;}
        public String objetivo { get; set; }
        public String tipo { get; set; }
        public int duracion { get; set; }
        public String lugar { get; set; } 
    }
}