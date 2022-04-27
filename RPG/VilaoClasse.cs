using System;

namespace OODesafio
{
    class Vilao
    {
        public int IdVilao;
        public string NomeVilao = "";
        public int PoderDeAtaqueVilao;
        public int VidaVilao;
        public Vilao(int IdVilao, string nomeVilao, int poderDeAtaqueVilao, int vidaVilao)
        {
            NomeVilao = nomeVilao;
            PoderDeAtaqueVilao = poderDeAtaqueVilao;
            VidaVilao = vidaVilao;
        }
        public static int SumonarChefe()
        {
            Random chefe = new Random();
            return chefe.Next(1,4);
        }
    }
}