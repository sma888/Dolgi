using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateLogLibrary
{
    
    public class Class1
    {
        private readonly string _path = @"C://Logi";

        public Class1()
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
        }

        public async Task Create(string e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            var filePath = _path + @"\" + date + ".txt";
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            StreamWriter writer = new StreamWriter(filePath, false);
            await writer.WriteLineAsync("Ошибка: " + e.ToString());
            writer.Close();
        }
    }
}
