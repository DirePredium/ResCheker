using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResCheker
{
    interface IFileHandler {
        public void SaveRes<T>(string DBFilePath, T objectForSave);
        public T ReadRes<T>(string DBFilePath);
    };
    
}
