using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    class Nodo
    {
        private Aluno aluno;
        private Nodo proximo;

        public Aluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

        public Nodo Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
    }
}
