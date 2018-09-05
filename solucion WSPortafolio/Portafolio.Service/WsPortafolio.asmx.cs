using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;

namespace Portafolio.Service
{
    /// <summary>
    /// Descripción breve de WsPortafolio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WsPortafolio : IWsPortafolio
    {
        [WebMethod]
        public bool Validar(string userName, string password)
        {
            try
            {
                Negocio.Usuario user = new Negocio.Usuario()
                {
                    NombreUsuario = userName.Trim(),
                    Pass = password.Trim()
                };

                return user.ValidarUsuario();
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        }
    }

