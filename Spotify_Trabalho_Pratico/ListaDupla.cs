using Spotify_Trabalho_Pratico;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMusical
{
    internal class ListaDupla
    {
        private Celula primeiro, ultimo;
        private int tamanho;
        public ListaDupla()
        {
            primeiro = new Celula();
            ultimo = primeiro;
            tamanho = 0;
        }

        public int Tamanho
        {
            get { return this.tamanho; }
            set { this.tamanho = value; }
        }

        public void InserirFim(Musica music)
        {
            ultimo.Prox = new Celula(music);
            ultimo.Prox.Ant = ultimo;
            ultimo = ultimo.Prox;
            tamanho++;
        }
        public void InserirInicio(Musica music)
        {
            Celula tmp = new Celula(music);
            tmp.Ant = primeiro;
            tmp.Prox = primeiro.Prox;
            primeiro.Prox = tmp;
            if (primeiro == ultimo)
                ultimo = tmp;
            else
                tmp.Prox.Ant = tmp;
            tmp = null;
            tamanho++;
        }

        public void Inserir(Musica music, int posicao)
        {
            if (posicao < 0 || posicao > Tamanho)
                Console.WriteLine($"Não é posivel inserir na posição {posicao}");
            else if (posicao == 0)
                InserirInicio(music);
            else if (posicao == tamanho)
                InserirFim(music);
            else
            {
                Celula i = primeiro;
                for (int j = 0; j < posicao; j++, i = i.Prox) ;
                Celula tmp = new Celula(music);
                tmp.Ant = i;
                tmp.Prox = i.Prox;
                tmp.Ant.Prox = tmp.Prox.Ant = tmp;
                tmp = i = null;
                tamanho++;
            }
        }

        public Musica Remover(int pos)
        {
            Musica music = null;
            if (primeiro == ultimo)
            {
                Console.WriteLine("Lista Vazia");
                return music;
            }
            else if (pos < 0 || pos > Tamanho)
            {
                Console.WriteLine($"Não é posivel remover na posição {pos}");
                return music;
            }
            else
            {
                Celula i = primeiro;
                for (int j = 0; j <= pos; j++, i = i.Prox) ;
                i.Ant.Prox = i.Prox;
                i.Prox.Ant = i.Ant;
                music = i.Music;
                i.Prox = i.Ant = null;
                i = null;
                tamanho--;
            }
            return music;
        }
    }
}
