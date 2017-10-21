using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoAngularServer.Models
{
    public class Recurso
    {
        public int id { get; set; }
        public String fuente { get; set; }
        public int valor { get; set; }
        public String observacion { get; set; }
        public String proyectoId { get; set; }
    }
}