using System;

namespace Estudante
{
    class Estudante
    {
        private int codigo;
        private string nome, curso, turma;
        private long contacto;
        private double teste1, teste2;

        public Estudante(int codigo, string nome, string curso, string turma, long contacto, double teste1, double teste2)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.curso = curso;
            this.turma = turma;
            this.contacto = contacto;
            this.teste1 = teste1;
            this.teste2 = teste2;
        }

        public Estudante()
        {

        }

        public int GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetCurso()
        {
            return curso;
        }

        public void SetCurso(string curso)
        {
            this.curso = curso;
        }

        public string GetTurma()
        {
            return turma;
        }

        public void SetTurma(string turma)
        {
            this.turma = turma;
        }

        public long GetContacto()
        {
            return contacto;
        }

        public void SetContacto(long contacto)
        {
            this.contacto = contacto;
        }

        public double GetTeste1()
        {
            return teste1;
        }

        public void SetTeste1(double teste1)
        {
            this.teste1 = teste1;
        }

        public double GetTeste2()
        {
            return teste2;
        }

        public void SetTeste2(double teste2)
        {
            this.teste2 = teste2;
        }

        public override string ToString()
        {
            return base.ToString() + media();
        }

        public void imprimir()
        {
            Console.WriteLine(ToString() + media());
        }

        public double media()
        {
            double med = (this.teste1 + this.teste2) / 2;

            return med;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
