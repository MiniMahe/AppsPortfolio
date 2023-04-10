using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Docente : Profesor
    {
        private string _Contrato;

        public string Contrato
        {
            get { return _Contrato; }
            set { _Contrato = value; }
        }

        public Docente(string name, string contrato) : base(name)
        {
            Name = name;
            _Contrato = contrato;
        }
        public void Imprimir()
        {
            base.Impress();
            Console.WriteLine(" " + _Contrato);
        }
    }
}
