using System;
using System.Collections.Generic;

namespace Clases
{
    class Clase
    {
        private string _Name;
        private List<Interino> _InterList;
        private List<Docente> _DocenteList;
        private List<Alumno> _AlumnoList;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Clase(string name, List<Interino> i, List<Docente> d, List<Alumno> a)
        {
            _Name = name;
            if (a == null)
            {
                _AlumnoList = new List<Alumno>();
            }
            else
                _AlumnoList = a;
            if (i == null)
            {
                _InterList = new List<Interino>();
            }
            else
                _InterList = i;
            if (d == null)
            {
                _DocenteList = new List<Docente>();
            }
            else
                _DocenteList = d;
        }
        public void Editar(string name, List<Interino> i, List<Docente> d, List<Alumno> a)
        {
            _Name = name;
            _AlumnoList = a;
            _InterList = i;
            _DocenteList = d;
        }
        public void Borrar()
        {
            _InterList.Clear();
            _DocenteList.Clear();
            _AlumnoList.Clear();
            _Name = string.Empty;
        }
        public void Impress()
        {
            Console.Write(_Name);
        }
    }
}
