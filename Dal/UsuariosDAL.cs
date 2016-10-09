using Entidades; 
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace Dal
{
    public class SistemaRegistroDb : DbContext
    {
        public SistemaRegistroDb() : base("name= ConStr")
        {

        }

        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
