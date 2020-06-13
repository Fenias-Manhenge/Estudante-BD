using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Estudante
{
    class MetodosDoEstudante
    {
        public static Object objecto()
        {
            Estudante e = new Estudante();

            return e; 
        }

        public static ArrayList introduzir()
        {
            Estudante e;
            ArrayList a = new ArrayList();

            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o codigo: ");
            int codigo = int.Parse(Console.ReadLine());

            do
            {
                e = new Estudante();

                e.SetNome(nome);
                e.SetCodigo(codigo);
                Console.WriteLine("Digite o contacto: ");
                e.SetContacto(long.Parse(Console.ReadLine()));
                Console.WriteLine("Digite o Curso: ");
                e.SetCurso(Console.ReadLine());
                Console.WriteLine("Digite a turma: ");
                e.SetTurma(Console.ReadLine());
                Console.WriteLine("INTRODUZA O 1º TESTE: ");
                e.SetTeste1(double.Parse(Console.ReadLine()));
                Console.WriteLine("INTRODUZA O 2º TESTE: ");
                e.SetTeste2(double.Parse(Console.ReadLine()));

                a.Add(e);

                return a;

            } while (nome != null && codigo != 0);
        }

        public void imprime(ArrayList a)
        {
            foreach (Estudante d in a)
            {
                Console.WriteLine(d.ToString() + d.media());
            }
        }

        public void imprimirSeq(ArrayList a)
        {
            foreach (Estudante f in a)
            {
                    Console.WriteLine(f.GetNome() + f.media());
            }
        }

        public void imprimirDis(ArrayList a)
        {
            foreach (Estudante g in a)
            {
                if (g.media() > 14)
                {
                    Console.WriteLine(g.GetNome());
                }
            }
        }

    }
}
