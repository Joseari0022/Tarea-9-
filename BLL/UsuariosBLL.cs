using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using Dal;

namespace BLL
{
    public class UsuariosBLL
    {
        Usuarios usuario = new Usuarios();

        public static void Insertar(Usuarios u)
        {
            try
            {
                using (var db = new SistemaRegistroDb())
                {
                    db.Usuarios.Add(u);
                    db.SaveChanges();
                    db.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Usuarios Buscar(int Id)
        {
                var db = new SistemaRegistroDb();
             return db.Usuarios.Find(Id);
        }

        public static void Eliminar (int Id)
        {
            var db = new SistemaRegistroDb();
            Usuarios us = db.Usuarios.Find(Id);

            db.Usuarios.Remove(us);
            db.SaveChanges();
        }

        }
    }

