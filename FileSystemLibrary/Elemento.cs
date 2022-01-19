using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLibrary
{
    public abstract class Elemento
    {
        private string nome { get; }
        public Elemento(string nome)
        {
            this.nome = nome;
        }
        public abstract long GetDimensione();
        public virtual string Stampa()
        {
            return nome;
        }
    }
}
