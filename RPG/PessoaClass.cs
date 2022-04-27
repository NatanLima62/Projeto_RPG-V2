using System;

namespace OODesafio
{
    class Pessoa
    {
        public string Name = "";
        public int Idade;

        public Pessoa(string nome, int idade)
        {
            Name = nome;
            Idade = idade;
        }
        public Pessoa()
        {

        }
        public void Apresentacao(string nome, int idade)
        {
            Console.WriteLine($"Meu nome é {nome} e tenho de {idade}");
        }

    }
}
