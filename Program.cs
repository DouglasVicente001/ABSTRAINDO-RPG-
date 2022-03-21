using AbstraindoRPG.Models;
using static System.Console;

namespace ABSTRAINDORPG
{
      class program
      {
            
            public static void Main(string[]args)
            {
            int Opcao;
            string Decisao = "s";
            while (Decisao == "s")
            {
            WriteLine("------------------------");
            WriteLine("FINAL FANTASY ORIGINS");
            WriteLine("------------------------");

            WriteLine("START - Selecione uma das opções abaixo:");
            WriteLine();
            WriteLine("Mostrar todos os personagens. Pressione (1):");
            WriteLine("Conferir boss final. Pressione (2):");
            WriteLine("Sair. Pressione (3):");
            Opcao = int.Parse(ReadLine());

            switch (Opcao)
            {
            case 1 :
            Knight Arus  = new Knight("Arus ",42," Knight ",469,749,72,72);
            WriteLine(Arus);
            WriteLine(Arus.Attack(60));
            WriteLine();
            
            Ninja Wedge = new Ninja("Wedge ",42," Ninja ",292,574,89,89);
            WriteLine(Wedge);
            WriteLine(Wedge.Attack(72));
            WriteLine();

            WriteWizard Jenica = new WriteWizard("Jenica ",42," WriteWizard ",325,601,474,482);
            WriteLine(Jenica);
            WriteLine(Jenica.Attack(52));
            WriteLine();

            BlackWizard Topapa = new BlackWizard("Topapa ",42," Ninja ",106,385,611,641);
            WriteLine(Topapa);
            WriteLine(Topapa.Attack(80));
            WriteLine();
            break;
            
            case 2: 
            WriteLine();
            Boss Nemesis = new Boss("Nemesis ",184," Demom ",687,1050,888,1050);
            WriteLine(Nemesis);
            WriteLine(Nemesis.Attack(150));
            WriteLine();
            break;

            case 3:
            WriteLine();
            WriteLine("Quer mesmo sair de Final Fantasy Oringins?");
            break;

            default :
            WriteLine ("Digite um número válido");
            break;
            }

            WriteLine ("Deseja continuar ? [S]sim / [N]não");
            Decisao = ReadLine();
                        if (Decisao.Equals("n",StringComparison.InvariantCultureIgnoreCase))
                        {
                        WriteLine("Você acaba de acessar ao Final Fantasy Origins, obrigado.");
                        }
                        else
                        {
                        WriteLine("Digite uma opção válida!");
                        }
            }
            
            }
      }
}