using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMusical
{
    internal class Musica
    {
        private string titulo;
        private string artista;
        private string genero;
        private int duracao;

        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }
        public string Artista
        {
            get { return this.artista; }
            set { this.artista = value; }
        }
        public string Genero
        {
            get { return this.genero; }
            set { this.genero = value; }
        }
        public int Duracao
        {
            get { return this.duracao; }
            set { this.duracao = value; }
        }
        public Musica(string titulo, string artista, string genero, int duracao)
        {
            this.titulo = titulo;
            this.artista = artista;
            this.genero = genero;
            this.duracao = duracao;
        }

    }
}
