using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Livro
    {
       
        #region atributos
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;
        #endregion
                
        #region propriedades
        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }
        #endregion

        #region construtores
        //contrutores
        public Livro (int isbn, string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.editora = editora;
            this.autor = autor;
        }
        public Livro(int isbn)
        {
            this.isbn = isbn;
        }
        public Livro()
            : this(0, "", "","")
        {
        }
        #endregion
              
        #region metodos
        public void adicionarExemplar(Exemplar exemplar)
        {
            this.exemplares.Add(exemplar);
        }
        public int qtdeExemplares()
        {
            return 0;
        }
        public int qtdeDisponiveis()
        {
            return 0;
        }
        public int qtdeEmprestimos()
        {
            return 0;
        }
        public double percDisponibilidade()
        {
            return 0;
        }
        #endregion

        #region Sobreescritas
        public override bool Equals(object obj)
        {
            Livro p = (Livro)obj;
            return this.isbn.Equals(p.isbn);
        }
        #endregion
    }
}
