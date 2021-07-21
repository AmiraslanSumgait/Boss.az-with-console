using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace boss.az
{
    class JsonFormat
    {
        public static void WriteToJsonFile<T>(T obj,string path)
        {
            var options = new JsonSerializerOptions(); options.WriteIndented = true;
            var textJson = JsonSerializer.Serialize(obj, options);
            File.WriteAllText(path, textJson);
        }
    }
}
