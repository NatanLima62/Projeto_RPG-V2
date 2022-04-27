using System;

namespace OODesafio
{
    class Heroi
    {
        public int IdHeroi;
        public string ClasseHeroi = "";
        public int PoderDeAtaqueHeroi;
        public int VidaHeroi;
        public Heroi(int idHeroi, string classeHeroi, int poderDeAtaqueHeroi, int vidaHeroi)
        {
            idHeroi = IdHeroi;
            ClasseHeroi = classeHeroi;
            PoderDeAtaqueHeroi = poderDeAtaqueHeroi;
            VidaHeroi = vidaHeroi;
        }
        public static int Atacar(int poderDeAtaqueHeroi, int vidaVilao)
        {
            vidaVilao -= poderDeAtaqueHeroi;
            return 0;
        }
    }
}