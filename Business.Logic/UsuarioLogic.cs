using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioAdapter UsuarioData;

        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }

        public List<Usuario> GetAll()
        {
            try
            {
                List<Usuario> Usuarios = UsuarioData.GetAll();
                return Usuarios;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de usuarios", Ex);
                throw ExcepcionManejada;
            }
                
        }
        public Usuario GetOne(int idUsuario)
        {
            Usuario OneUser = UsuarioData.GetOne(idUsuario);
            return OneUser;
        }

        public void Delete(int idUsuario) 
        {
            UsuarioData.Delete(idUsuario);
        }
        public void Save(Usuario ip_usuario) 
        {
            UsuarioData.Save(ip_usuario);
        }

        public bool Login(string user, string pass) 
        {
            try
            {
                bool respuesta;
                respuesta = UsuarioData.Login(user, pass);
                return respuesta;

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar el nombre de usuario", Ex);
                throw ExcepcionManejada;
            }
            
        }
    }
}
