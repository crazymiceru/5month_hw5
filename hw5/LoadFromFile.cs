using System;
using System.IO;

namespace hw5
{
    internal sealed class LoadFromFile : ILoad
    {
        public string Load(string path)
        {
            string outString=null;
            if (File.Exists(path))
            {
                outString=File.ReadAllText(path);
            }
            else throw new Exception($"Отсутсвтует файл: {path}");
            return outString;
        }
    }
}
