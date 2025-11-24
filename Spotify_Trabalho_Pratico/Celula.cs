using Spotify_Trabalho_Pratico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMusical
{
    internal class Celula
    {
        private Musica music;
        private Celula prox, ant;

        public Celula(Musica music)
        {
            this.music = music;
            this.prox = null;
            this.ant = null;
        }

        public Celula()
        {
            this.music = null;
            this.prox = null;
            this.ant = null;
        }

        public Celula Prox
        {
            get { return this.prox; }
            set { this.prox = value; }
        }
        public Celula Ant
        {
            get { return this.ant; }
            set { this.ant = value; }
        }
        public Musica Music
        {
            get { return this.music; }
            set { this.music = value; }
        }
    }
}
