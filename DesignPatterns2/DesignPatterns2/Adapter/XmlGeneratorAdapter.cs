using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns2.Adapter
{
    public class XmlGeneratorAdapter
    {
        /*
         * No Adapter estamos adaptando a interface de um sistema antigo para que ela possa se encaixar em um sistema novo.
         * Já no Strategy a ideia é utilizar diferentes estratégias para resolver um dado problema no sistema.
         * o Adapter serve para adaptar o código de um sistema legado ou biblioteca para que ele possa ser utilizado no novo sistema. 
         * Já o command serve para guardarmos um trecho de código que precisa ser executado posteriormente.
         */
        public string GenerateXml(Object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, obj);
            return writer.ToString();
        }
    }
}
