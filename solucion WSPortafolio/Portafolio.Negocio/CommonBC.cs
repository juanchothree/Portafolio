using Portafolio.DALC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Portafolio.Negocio
{
    public class CommonBC
    {
        private static PortafolioEntities _modelo;

        public static PortafolioEntities Modelo
        {
            get
            {
                if (_modelo == null)
                {
                    _modelo = new PortafolioEntities();
                }
                return _modelo;
            }
        }

        public static string Serializar<T>(object objeto)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            StringWriter writer = new StringWriter();

            serializador.Serialize(writer, objeto);

            return writer.ToString();
        }

        public static T Deserializar<T>(string xml)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            StringReader reader = new StringReader(xml);

            return (T)serializador.Deserialize(reader);
        }


        public CommonBC()
        {

        }
    }
}
