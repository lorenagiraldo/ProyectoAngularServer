using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoAngularServer.Models
{
    public class Profesor
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String cedula { get; set; }
        public String correo { get; set; }
        public String facultad { get; set; }
        
    }
}