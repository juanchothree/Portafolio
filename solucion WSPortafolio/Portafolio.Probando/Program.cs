using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portafolio.Probando
{
    class Program
    {
        static void Main(string[] args)
        {

            Negocio.Usuario user = new Negocio.Usuario()
            {
                NombreUsuario = "a",
                Pass = "a"
            };

            user.Serializar();

            user.ValidarUsuario();
            Console.WriteLine(user.Read());
            Console.ReadKey();
        }
    }
}
