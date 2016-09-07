using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    class FilaDinamica
    {
        private int quantidade = 0;
        private Nodo fim = null;
        private Nodo inicio = null;
        public int Tamanho
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public Nodo Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        public Nodo Fim
        {
            get { return fim; }
            set { fim = value; }
        }
        public void Enfileirar(Aluno aluno)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.Aluno = aluno;
            if (fim == null)
                inicio = fim = novoNodo;
            else
            {
                fim.Proximo = novoNodo;
                fim = novoNodo;
            }
            Tamanho++;
        }
        public Aluno Desenfileira()
        {
            if (Tamanho == 0)
            {
                throw new Exception("A fila está vazia!");
            }
            else
            {
                var retorno = inicio;
                inicio = inicio.Proximo;
                quantidade--;
                return retorno.Aluno;
            }
        }
        public string ListarItems()
        {
            if (Tamanho == 0)
            {
                throw new Exception("A fila está vazia!");
            }
            else
            {
                var retorno = "";
                var continuar = true;
                var nodo = Inicio;
                do
                {
                    var aluno = nodo.Aluno;
                    retorno += "RA: " + aluno.Ra + " | Nome: " + aluno.Nome + "\r\n";

                    if (nodo.Proximo == null)
                        continuar = false;
                    else
                        nodo = nodo.Proximo;
                } while (continuar);

                return retorno;
            }
        }
    }
}