﻿using ProyectoAngularServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoAngularServer.DataAccess
{
    public class ProfesorDB : DbContext
    {
        public DbSet<Profesor> teachers { get; set; }
    }
}