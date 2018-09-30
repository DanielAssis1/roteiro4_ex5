using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro4_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 5 – Sabendo que somente os munícipios que possuem mais de 20.000 eleitores aptos
têm segundo turno nas eleições para prefeito caso o primeiro colocado não tenha mais do que 50%
dos votos, fazer um programa em C# que leia o nome do município, a quantidade de eleitores
aptos. Faça uma repetição para essa quantidade de eleitores aptos, identifique qual o candidato
votado. Ao final do programa, apresentar a porcentagem de votos de cada candidato, qual o
candidato mais votado e informar se ele terá ou não segundo turno em sua eleição municipal.*/
            int eleitores,VOTO, numV13 = 0, numV12 = 0, numV17 = 0, numV30 = 0, numV18 = 0;
            double media12, media13, media17, media30, media18;
            bool check = false;
           

                Console.Write("\n Digite o número de eleitores aptos: ");
                eleitores = int.Parse(Console.ReadLine());

                
                if (eleitores <= 0)
                {
                    Console.Write("O valor digitado é inválido.");
                    check =true;
                }
                else
                {
                    for (int i = 0; i < eleitores; i++) { 
                        Console.Write("CANDIDATOS: \n" +
                        "- [12] Candidato 1 \n" +
                        "- [13] Candidato 2\n" +
                        "- [17] Candidato 3\n" +
                        "- [18] Candidato 4\n" +
                        "- [30] Canditado 5\n" +
                        " Digite o seu voto: ");
                    VOTO = int.Parse(Console.ReadLine());
                    
                        if (VOTO == 12)
                        {
                            numV12++;
                        }
                        else if(VOTO == 13)
                        {
                            numV13++;
                        }
                        else if(VOTO == 17)
                        {
                            numV17++;
                        }
                        else if(VOTO == 18)
                        {
                            numV18++;
                        }
                        else if(VOTO == 30)
                        {
                            numV30++;
                        }
                        else
                        {
                        Console.Write("O valor digitado é inválido.");
                            i--;
                        }

                    }
                media12 = (numV12 * 100) / eleitores;
                media13 = (numV13 * 100) / eleitores;
                media17 = (numV17 * 100) / eleitores;
                media18 = (numV18 * 100) / eleitores;
                media30 = (numV30 * 100) / eleitores;
                Console.WriteLine("\n- [12] Candidato 1: " + (numV12 * 100) / eleitores+"%.");
                Console.WriteLine("\n- [13] Candidato 2: " + (numV13 * 100) / eleitores+"%.");
                Console.WriteLine("\n- [17] Candidato 3: " + (numV17 * 100) / eleitores+"%.");
                Console.WriteLine("\n- [18] Candidato 4: " + (numV18 * 100) / eleitores+"%.");
                Console.WriteLine("\n- [30] Candidato 5: " + (numV30 * 100) / eleitores+"%.");


                if (media12 > 51  && eleitores>=5)
                {
                    Console.Write("/nO candidato vencedor é o Candidato 1.");
                    Console.Write(" [Não haverá segundo turno.]");
                }
                else if (media13 > 51 && eleitores >= 5)
                {
                    Console.Write("/nO candidato vencedor é o Candidato 2.");
                    Console.Write(" [Não haverá segundo turno.]");
                }
                else if (media17 > 51 && eleitores >= 5)
                {
                    Console.Write("/nO candidato vencedor é o Candidato 3.");
                    Console.Write(" [Não haverá segundo turno.]");
                }
                else if (media18 > 51 && eleitores >= 5)
                {
                    Console.Write("/nO candidato vencedor é o Candidato 4.");
                    Console.Write(" [Não haverá segundo turno.]");
                }
                else if (media30 > 51 && eleitores >= 5)
                {
                    Console.Write("/nO candidato vencedor é o Candidato 5.");
                    Console.Write(" [Não haverá segundo turno.]");
                }

            }


            Console.ReadKey();
        }
    }
}
