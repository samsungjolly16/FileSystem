using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLibrary
{
    public class File:Elemento
    {
        public string Estensione { get; private set; }
        public string nome { get; set; }
        public File(string nome,long dimensione,string estensione):base(nome)
        {
            Dimensione = dimensione;
            Estensione = estensione;
            this.nome = nome;

        }
        public long Dimensione { get; private set; }
        public override long GetDimensione()
        {
            return Dimensione;
        }
        public override string Stampa()
        {
            return  base.Stampa() + Estensione + " " + "(" + Dimensione + "KB)";
            

        }
    }
}
