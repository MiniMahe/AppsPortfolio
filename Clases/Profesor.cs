using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clases
{
    class Profesor
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Profesor(string name)
        {
            _Name = name;
        }
        public void Impress()
        {
            Console.Write(_Name);
        }
    }
} 
    
