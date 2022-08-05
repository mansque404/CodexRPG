using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodexRPG
{
    internal class CodexGame : Personagem, IBoasVindas
    {
        public void ApresentarMensagemBoasVindas()
        {
            Console.WriteLine("Bem vindo ao CODEX - Arena de Gigantes");
        }
        public CodexGame()
        {
            RodarCodex();
        }
        private void RodarCodex()
        {
            ApresentarMensagemBoasVindas();
            
            Random rng = new Random();
            int redDragonChoice = rng.Next(0, 30);
            int desanChoice = rng.Next(0, 30);

            Personagem desan = new Personagem
            {
                Nome = "Desan",
                HP = 65,
                Dano = 28,
                Bloqueio = 19,
                Especial = rng
            };
            
            Personagem redDragon = new Personagem

            {
                Nome = "RedDragon",
                HP = 150,
                Dano = 16,
                Bloqueio = 4,
                Especial = rng
            };

            var personagens = new List<Personagem>();
            personagens.Add(redDragon);
            personagens.Add(desan);

            Console.WriteLine("A batalha será entre " + personagens.Count + " personagens!");

            while (desan.HP > 0
                && redDragon.HP > 0) 
            {
                //  HERÓI //
                Console.WriteLine("\n-- Turno do Herói --");
                Console.WriteLine("HP de Desan é: " + desan.HP + " || HP de RedDragon é: " + redDragon.HP);
                Console.WriteLine("Para atacar, pressione 'f' ou 'd' para Defender. Após sua escolha, pressione ENTER.");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "f":
                        {
                            redDragon.HP -= desan.Dano;
                            Console.WriteLine("Desan atravessa a sua lamina contra o dragão e causa " + desan.Dano + " de dano!");
                            break;
                        }
                    case "d":
                        {
                            desan.HP += desan.Bloqueio;
                            Console.WriteLine("Desan cura " + desan.Bloqueio + " de HP pela lança sagrada!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ops, comando errado! ataque ou defenda guerreiro.. Volte ao se decidir!");
                            Console.ReadLine();
                            break;
                        }
                }

              /*  if (choice == "f")
                {
                    redDragon.HP -= desan.Dano;
                    Console.WriteLine("Desan atravessa a sua lamina contra o dragão e causa " + desan.Dano + " de dano!");
                }
                if (choice == "d")
                {
                    desan.HP += desan.Bloqueio;
                    Console.WriteLine("Desan cura " + desan.Bloqueio + " de HP pela lança sagrada!");
                }
                if (choice != "f" && choice != "d")
                {
                    Console.WriteLine("Ops, comando errado! ataque ou defenda guerreiro.. Volte ao se decidir!");
                    Console.ReadLine();
                    return;
                }
              */

                if (redDragon.HP > 11)
                {
                    // DRAGÃO //
                    Console.WriteLine("\n -- Turno do Dragão -- ");
                    Console.WriteLine("HP de Desan é: " + desan.HP + " || HP de RedDragon é: " + redDragon.HP);

                    if (desan.HP >= 5)
                    {
                        desan.HP -= redDragon.Dano;
                        Console.WriteLine("O Dragão ataca e causa " + redDragon.Dano + " de dano no herói!");
                    }
                    else
                    {
                        redDragon.HP += redDragon.Bloqueio;
                        Console.WriteLine("O Dragão ergue sua pele e ganha " + redDragon.Bloqueio + " de armadura!");
                    }
                    if (desan.HP <= 2)
                    {
                        desan.HP -= redDragonChoice;
                        Console.WriteLine("RedDragon utiliza sua ultimate e causa " + redDragonChoice + " de dano finalizador!");
                    }
                    if (redDragon.HP <= 10)
                    {
                        redDragon.HP -= desanChoice;
                        Console.WriteLine("Desan utiliza sua ultimate e causa " + desanChoice + " de dano finalizador!");
                    }
                }
            }
            if (desan.HP > 0)
            {
                Console.WriteLine(" --- Desan derrotou o temível dragão vermelho! --- ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" --- Desan perdeu a batalha contra a fera.. --- ");
                Console.ReadLine();
            }
        }
    }
}
/* 
- Try / Catch
- Classe OBJECT
- List, lambda, linqF
- Entrada e saida (I/O) streams
*/