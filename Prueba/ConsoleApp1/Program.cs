using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Portafolio.Negocio.UsuariosOntour user = new Portafolio.Negocio.UsuariosOntour()
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
