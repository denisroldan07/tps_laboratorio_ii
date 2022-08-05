using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Archivos
{
    public class Json<T> : IArchivos<T>
    {
        string folder;

        public Json()
        {
            folder = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"VuelosDb");
        }

        public bool Save(string file, T data)
        {
            try
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                file = folder + file;

                string jsonObject = JsonSerializer.Serialize(data);
                File.WriteAllText(file, jsonObject);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo guardar el archivo: {file}", ex);
            }
        }

        public bool Read(string file, out T data)
        {
            try
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                file = folder + file;
                string jsonObject = File.ReadAllText(file);

                data = JsonSerializer.Deserialize<T>(jsonObject);

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception($"No se pudo leer el archivo: {file}", ex);
            }
        }
    }
}
