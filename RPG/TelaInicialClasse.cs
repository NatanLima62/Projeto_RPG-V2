using System;

namespace OODesafio
{
    class TelaInicial
    {
       public static int Tela()
       {
           Console.WriteLine("1 - Mago");
           Console.WriteLine("2 - Assassino");
           Console.WriteLine("3 - Guerreiro");
           Console.WriteLine("4 - Arqueiro");
           Console.WriteLine("5 - Sair");
           Console.WriteLine("Escolha uma das classes acima para continuar");
           int opcao = int.Parse(Console.ReadLine());
           return opcao;
       }
       public static int Batalha()
       {
           Console.WriteLine("1 - Atacar");
           Console.WriteLine("2 - Defender");
           int opcao = int.Parse(Console.ReadLine());
           return opcao;
       }
    }
}