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
            catch (Exception e)
            {
                throw e;
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

        public static List<Usuarios> GetListaIdUsuarios(int Id)
        {
            List<Usuarios> lista = new List<Usuarios>();
            var db = new SistemaRegistroDb();
            lista = db.Usuarios.Where(o => o.IdUsuario == Id).ToList();
            return lista;
        }

        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();
            var db = new SistemaRegistroDb();
            lista = db.Usuarios.ToList();
            return lista;
        }

        public static List<Usuarios> GetListaNombreUsuario(string au)
        {
            List<Usuarios> lista = new List<Usuarios>();
            var db = new SistemaRegistroDb();
            lista = db.Usuarios.Where(o => o.NombreUsuario == au).ToList();
            return lista;
        }

        public static void Modificar(int Id, Usuarios usuario)
        {
            var db = new SistemaRegistroDb();
            Usuarios u = db.Usuarios.Find(Id);

            u.NombreUsuario = usuario.NombreUsuario;
            u.Contrasena = usuario.Contrasena;
            db.SaveChanges();
        }

        }
    }

