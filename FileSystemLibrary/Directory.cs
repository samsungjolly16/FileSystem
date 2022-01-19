using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLibrary
{
    public class Directory : Elemento
    {
        public  List<Elemento> Elementi { get; } = new List<Elemento>();
        public string Nome { get; private set; }
        public  Directory(string nome):base(nome)
        {
            Nome = nome;
        }
        public void AddElementi(Elemento el)
        {
            Elementi.Add(el);
        }
        public override long GetDimensione()
        {
            long d=0;
            foreach(Elemento e in Elementi)
            {
               d+=e.GetDimensione();
            }
            return d;
        }
        public override string Stampa()
        {
            return $"\n---|--/{Nome}";
        }

    }
}
