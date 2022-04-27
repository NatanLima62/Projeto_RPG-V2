using System;

namespace OODesafio
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            //instanciar a classe heroi
            Heroi mago = new Heroi(1,"Mago",50,500);
            Heroi assassino = new Heroi(2,"Assassino",50,500);
            Heroi guerreiro = new Heroi(3,"Guerreiro",50,500);
            Heroi arqueiro = new Heroi(4,"Arqueiro",50,500);
            //instanciar a classe vilao
            Vilao chefeDosAssassinos = new Vilao(1,"Chefe Dos Assassino",40,450);
            Vilao aranhaGigante = new Vilao(2,"Aranha Gigante",40,450);
            Vilao reiGnomo = new Vilao(3,"Rei gnomo",40,450);
            Vilao slime = new Vilao(4,"Slime",40,450);

            //"Escolhendo a classe"
            int opcao = TelaInicial.Tela();

            //iniciando o jogo
            Console.Clear();
            if (opcao == 1)
            {
                Console.WriteLine("Parabens você escolheu a classe mago");
                Console.WriteLine($"Seu Status: Vida = {mago.VidaHeroi}| Poder de ataque = {mago.PoderDeAtaqueHeroi}");
                int chefe = Vilao.SumonarChefe();
                if (chefe == 1)
                {
                    Console.WriteLine("O vilao Chefe dos assassinos apareceu!!");
                    Console.WriteLine($"Status do chefe: Vida = {chefeDosAssassinos.VidaVilao}| Ataque = {chefeDosAssassinos.PoderDeAtaqueVilao}");
                    while (chefeDosAssassinos.VidaVilao > 0 && mago.VidaHeroi > 0)
                    {
                        int opcaoBatalha = TelaInicial.Batalha();
                        if (opcaoBatalha == 1)
                        {
                            Console.WriteLine("Você atacou!");
                            chefeDosAssassinos.VidaVilao -= mago.PoderDeAtaqueHeroi;
                            Console.WriteLine($"Status do vilão: Vida = {chefeDosAssassinos.VidaVilao}| Ataque = {chefeDosAssassinos.PoderDeAtaqueVilao}");
                            Console.WriteLine("Chefe dos Asssassinos atacou!!");
                            mago.VidaHeroi -= chefeDosAssassinos.PoderDeAtaqueVilao;
                            Console.WriteLine($"Seu Status: Vida = {mago.VidaHeroi}| Ataque = {mago.PoderDeAtaqueHeroi}");
                        }
                        else
                        {
                            Console.WriteLine("Você defendeu");
                            mago.VidaHeroi -= 20;
                            Console.WriteLine($"Seu Status: Vida = {mago.VidaHeroi}| Ataque = {mago.PoderDeAtaqueHeroi}");
                        }
                    }
                    if (mago.VidaHeroi <= 0)
                            {
                                Console.WriteLine("Você morreu!");
                            } else if (chefeDosAssassinos.VidaVilao <= 0)
                            {
                                Console.WriteLine("Voce conseguiu derrotar o chefe");
                            }
                } else if (chefe == 2)
                {
                    Console.WriteLine("O vilao Aranha gigante apareceu!!");
                    Console.WriteLine($"Status do chefe: Vida = {aranhaGigante.VidaVilao}| Ataque = {aranhaGigante.PoderDeAtaqueVilao}");
                    while (aranhaGigante.VidaVilao > 0 && mago.VidaHeroi > 0)
                    {
                        int opcaoBatalha = TelaInicial.Batalha();
                        if (opcaoBatalha == 1)
                        {
                            Console.WriteLine("Você atacou!");
                            aranhaGigante.VidaVilao -= mago.PoderDeAtaqueHeroi;
                            Console.WriteLine($"Status do vilão: Vida = {aranhaGigante.VidaVilao}| Ataque = {aranhaGigante.PoderDeAtaqueVilao}");
                            Console.WriteLine("Chefe dos Asssassinos atacou!!");
                            mago.VidaHeroi -= aranhaGigante.PoderDeAtaqueVilao;
                            Console.WriteLine($"Seu Status: Vida = {mago.VidaHeroi}| Ataque = {mago.PoderDeAtaqueHeroi}");
                        }
                        else
                        {
                            Console.WriteLine("Você defendeu");
                            mago.VidaHeroi -= 20;
                            Console.WriteLine($"Seu Status: Vida = {mago.VidaHeroi}| Ataque = {mago.PoderDeAtaqueHeroi}");
                        }
                    }
                    if (mago.VidaHeroi <= 0)
                            {
                                Console.WriteLine("Você morreu!");
                            } else if (aranhaGigante.VidaVilao <= 0)
                            {
                                Console.WriteLine("Voce conseguiu derrotar o chefe");
                            }
                } else if (chefe == 3)
                {
                    Console.WriteLine("O vilao Rei Gnomo apareceu!!");
                    Console.WriteLine($"Status do chefe: Vida = {reiGnomo.VidaVilao}| Ataque = {reiGnomo.PoderDeAtaqueVilao}");
                    while (reiGnomo.VidaVilao > 0 && mago.VidaHeroi > 0)
                    {
                        int opcaoBatalha = TelaInicial.Batalha();
                        if (opcaoBatalha == 1)
                        {
                            Console.WriteLine("Você atacou!");
                            reiGnomo.VidaVilao -= mago.PoderDeAtaqueHeroi;
                            Console.WriteLine($"Status do vilão: Vida = {reiGnomo.VidaVilao}| Ataque = {reiGnomo.PoderDeAtaqueVilao}");
                            Console.WriteLine("Chefe dos Asssassinos atacou!!");
                            mago.VidaHeroi -= reiGnomo.PoderDeAtaqueVilao;
                            Console.WriteLine($"Seu Status: Vida = {mago.VidaHeroi}| Ataque = {mago.PoderDeAtaqueHeroi}");
                        }
                        else
                        {
                            Console.WriteLine("Você defendeu");
                            mago.VidaHeroi -= 20;
                            Console.WriteLine($"Seu Status: Vida = {mago.VidaHeroi}| Ataque = {mago.PoderDeAtaqueHeroi}");
                        }
                    }
                    if (mago.VidaHeroi <= 0)
                            {
                                Console.WriteLine("Você morreu!");
                            } else if (reiGnomo.VidaVilao <= 0)
                            {
                                Console.WriteLine("Voce conseguiu derrotar o chefe");
                            }
                } else if (chefe == 4)
                {
                    Console.WriteLine("O vilao Slime apareceu!!");
                    Console.WriteLine($"Status do chefe: Vida = {slime.VidaVilao}| Ataque = {slime.PoderDeAtaqueVilao}");
                    while (slime.VidaVilao > 0 && mago.VidaHeroi > 0)
                    {
                        int opcaoBatalha = TelaInicial.Batalha();
                        if (opcaoBatalha == 1)
                        {
                            Console.WriteLine("Você atacou!");
                            slime.VidaVilao -= mago.PoderDeAtaqueHeroi;
                            Console.WriteLine($"Status do vilão: Vida = {slime.VidaVilao}| Ataque = {slime.PoderDeAtaqueVilao}");
                            Console.WriteLine("Chefe dos Asssassinos atacou!!");
                            mago.VidaHeroi -= slime.PoderDeAtaqueVilao;
                            Console.WriteLine($"Seu Status: Vida = {mago.VidaHeroi}| Ataque = {mago.PoderDeAtaqueHeroi}");
                        }
                        else
                        {
                            Console.WriteLine("Você defendeu");
                            mago.VidaHeroi -= 20;
                            Console.WriteLine($"Seu Status: Vida = {mago.VidaHeroi}| Ataque = {mago.PoderDeAtaqueHeroi}");
                        }
                    }
                    if (mago.VidaHeroi <= 0)
                            {
                                Console.WriteLine("Você morreu!");
                            } else if (slime.VidaVilao <= 0)
                            {
                                Console.WriteLine("Voce conseguiu derrotar o chefe");
                            }
                } 

            } else if (opcao == 2)
            {
                Console.WriteLine("Parabens você escolheu a classe Assassino");
                Console.WriteLine($"Seu Status: Vida = {assassino.VidaHeroi}| Poder de ataque = {assassino.PoderDeAtaqueHeroi}");
                
                
            } else if (opcao == 3)
            {
                Console.WriteLine("Parabens você escolheu a classe Guerreiro");
                Console.WriteLine($"Seu Status: Vida = {guerreiro.VidaHeroi}| Poder de ataque = {guerreiro.PoderDeAtaqueHeroi}");
                
            } else if (opcao == 4)
            {
                Console.WriteLine("Parabens você escolheu a classe Arqueiro");
                Console.WriteLine($"Seu Status: Vida = {arqueiro.VidaHeroi}| Poder de ataque = {arqueiro.PoderDeAtaqueHeroi}");
                
            }

        }
    }
}
