using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Alumno
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Alumno(string name)
        {
            _Name = name;
        }
        public void Impress()
        {
            Console.Write(_Name);
        }
    }
}
