using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivos<T>
    {
        string folder;

        public Xml()
        {
            folder = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"\VuelosDb");
        }

        public bool Save(string file,T data)
        {
            try
            {
                if(!Directory.Exists(folder))
                { 
                    Directory.CreateDirectory(folder);
                }

                file = Path.Combine(folder, file);
                using (XmlTextWriter writer = new XmlTextWriter(file,Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, data);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo guardar el archivo: {file}",ex);
            }
        }

        public bool Read(string file,out T data)
        {
            try
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                file = Path.Combine(folder, file);
                using(XmlTextReader reader = new XmlTextReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    data = (T)serializer.Deserialize(reader);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"No se pudo leer el archivo: {file}",ex);
            }
        }
    }
}
