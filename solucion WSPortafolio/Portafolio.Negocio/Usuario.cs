using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portafolio.Negocio
{
   public class Usuario
    {
        public int Rut { get; set; }
        public string NombreUsuario { get; set; }
        public string Pass { get; set; }
        public int Perfiles { get; set; }

        public Usuario()
        {
            this.Init();
        }

        public string Serializar()
        {
            return CommonBC.Serializar<Usuario>(this);
        }

        private void Init()
        {
            Rut = 0;
            NombreUsuario = string.Empty;
            Pass = string.Empty;
            Perfiles = 0;
        }

        public Usuario(string xml)
        {
            Usuario user = CommonBC.Deserializar<Usuario>(xml);
            Rut = user.Rut;
            NombreUsuario = user.NombreUsuario;
            Pass = user.Pass;
            Perfiles = user.Perfiles;
        }

        public bool ValidarUsuario()
        {
            try
            {

                Portafolio1.DALC.USUARIOS user = CommonBC.Modelo.USUARIOS.First(u => u.NOMBRE_USUARIO.Trim() == NombreUsuario.Trim());

                return (user.CONTRASEÑA.Trim() == Pass);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Portafolio1.DALC.USUARIOS user = CommonBC.Modelo.USUARIOS.First(u => u.NOMBRE_USUARIO.Trim() == NombreUsuario.Trim());

                Rut = user.ID_USUARIO;
                Pass = user.CONTRASEÑA;
                Perfiles = user.PERFIL;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
