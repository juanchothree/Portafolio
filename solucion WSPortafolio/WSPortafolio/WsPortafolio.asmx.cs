using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace WSPortafolio
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
        public bool Validar(string userName, string password)
        {
            try
            {
                Portafolio.Negocio.Usuario user = new Negocio.Usuario()
                {
                    NombreUsuario = userName.Trim(),
                    Contrasenia = password.Trim()
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
