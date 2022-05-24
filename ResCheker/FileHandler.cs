using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResCheker
{
    class FileHandlerJson : IFileHandler
    {
        public void SaveRes<T>(string DBFilePath, T objectForSave)
        {
            string jsonString = System.Text.Json.JsonSerializer.Serialize(objectForSave);
            File.WriteAllText(DBFilePath, jsonString, Encoding.UTF8);
        }

        public T ReadRes<T>(string DBFilePath)
        {
            string jsonString = File.ReadAllText(DBFilePath, Encoding.UTF8);
            T currentRes = System.Text.Json.JsonSerializer.Deserialize<T>(jsonString)!;
            return currentRes;
        }
    }
}
