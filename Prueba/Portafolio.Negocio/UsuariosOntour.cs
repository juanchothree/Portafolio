using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio.Negocio
{
   public class UsuariosOntour
    {
        public int Rut { get; set; }
        public string NombreUsuario { get; set; }
        public string Pass { get; set; }
        public int Perfiles { get; set; }

        public UsuariosOntour()
        {
            this.Init();
        }

        public string Serializar()
        {
            return CommonBC.Serializar<UsuariosOntour>(this);
        }

        private void Init()
        {
            Rut = 0;
            NombreUsuario = string.Empty;
            Pass = string.Empty;
            Perfiles = 0;
        }

        public UsuariosOntour(string xml)
        {
            UsuariosOntour user = CommonBC.Deserializar<UsuariosOntour>(xml);
            Rut = user.Rut;
            NombreUsuario = user.NombreUsuario;
            Pass = user.Pass;
            Perfiles = user.Perfiles;
        }

        public bool ValidarUsuario()
        {
            try
            {

                Portafolo.DALC.USUARIOS user = CommonBC.Modelo.USUARIOS.First(u => u.NOMBRE_USUARIO.Trim() == NombreUsuario.Trim());

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
                Portafolo.DALC.USUARIOS user = CommonBC.Modelo.USUARIOS.First(u => u.NOMBRE_USUARIO.Trim() == NombreUsuario.Trim());

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
    