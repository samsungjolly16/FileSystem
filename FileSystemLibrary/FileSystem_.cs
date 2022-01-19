using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLibrary
{
    public class FileSystem_
    {
        private string Nome { get; }
        public FileSystem_(string nome)
        {
            Nome = nome;
        }

        public string  Stampa(string n1)
        {
            string s="";
            Directory dp = new Directory(n1);
            foreach(Directory d in dp.Elementi)
            {
                s += $"\n---|--/{d.Nome}";
                foreach(File f in dp.Elementi)
                {
                    s += $"\n------|--{f.Stampa()}";
                }
            }
            return "/" + Nome + "\n" + dp.Stampa()+s;
        }
    }
}
