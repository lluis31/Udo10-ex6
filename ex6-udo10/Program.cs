using System;

namespace ex6_udo10
{
    class Libro
    {
        private string Isbn;
        public string _Isbn { get { return Isbn; } set { Isbn = value; } }

        private string Titulo;
        public string _Titulo { get { return Titulo; } set { Titulo = value; } }

        private string Autor;
        public string _Autor { get { return Autor; } set { Autor = value; } }

        private int Num_pags;
        public int _Num_pags { get { return Num_pags; } set { Num_pags = value; } }

        public Libro()
        {
            _Isbn = "";
            _Titulo = "";
            _Autor = "";
            _Num_pags = 0;
        }

        public Libro(string I, string T, string A, int N)
        {
            _Isbn = I;
            _Titulo = T;
            _Autor = A;
            _Num_pags = N;
        }

        public override string ToString()
        {
            string a = "El libro " + this.Titulo + " con ISBN " + this._Isbn + " creado por el autor " + this._Autor + "tiene " + this._Num_pags + " páginas.";
            Console.WriteLine(a);
            return a;
        }

        class Program
        {
            static void Main()
            {
                Libro L1 = new Libro("9780544003415", "El Señor de los Anillos", "J.R.R. Tolkien", 1200);
                Libro L2 = new Libro("8478884459", "Harry Potter y el prisionero de Azkaban", "J.K. Rowling", 317);
                L1.ToString();
                L2.ToString();
                if (L1._Num_pags > L2._Num_pags)
                {
                    Console.WriteLine(L1._Titulo + " tiene más páginas.");
                }
                else
                {
                    Console.WriteLine(L2._Titulo + " tiene más páginas.");
                }
            }
        }
    }
}
