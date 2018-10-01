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
candidato mais votado e informar se ele terá ou não segundo turno em sua eleição municipal.
*/
            int eleitores,VOTO, cand1=0, cand2=0, cand3=0;
            double media1, media2, media3;
            bool check = false;
           

                Console.Write("\n Digite o número de eleitores aptos: ");
                eleitores = int.Parse(Console.ReadLine());

                
                if (eleitores <= 0)
                {
                    Console.Write("O valor digitado é inválido.");
                   
                }
                else
                {
                    for (int i = 0; i < eleitores; i++) {
                   

                        Console.Write("CANDIDATOS: \n" +
                        "- Candidato [1]\n" +
                        "- Candidato [2]\n" +
                        "- Candidato [3]\n" +
                        " Digite o seu voto:");

                        VOTO = int.Parse(Console.ReadLine());

                        if (VOTO <= 0 || VOTO > 3)
                        {
                            Console.Write("O valor digitado é inválido.");
                            i--;
                        }
                    else
                    {
                        switch (VOTO)
                        {
                            case 1:
                                cand1++;
                                break;
                            case 2:
                                cand2++;
                                break;
                            case 3:
                                cand3++;

                                break;
                        }

                      
                    }
                        
                   


                }
                media1 = (cand1 * 100) / eleitores;
                media2 = (cand2 * 100) / eleitores;
                media3 = (cand3 * 100) / eleitores;

                Console.WriteLine("\nCandidato 1 obteve: "+media1+"% dos votos");
                Console.WriteLine("\nCandidato 2 obteve: " + media2 + "% dos votos");
                Console.WriteLine("\nCandidato 3 obteve: " + media3 + "% dos votos\n \n");
                if (media1 > 51)
                {
                    Console.Write("O Candidato 1 venceu. Não Haverá segundo turno.");
                }
                else if (media2 > 51)
                {
                    Console.Write("O Candidato 2 venceu. Não Haverá segundo turno.");
                }
                else if (media3 > 51)
                {
                    Console.Write("O Candidato 3 venceu. Não Haverá segundo turno.");
                }
                else
                {
                    if(media1 >media2 && media2 >= media3 && eleitores >= 20000 )
                    {
                        Console.Write("O Candidato 1 venceu. Haverá segundo turno.");
                    }
                    if (media2 > media1 && media1 >= media3 && eleitores >= 20000)
                    {
                        Console.Write("O Candidato 2 venceu. Haverá segundo turno.");
                    }
                    if (media3 > media2 && media2 >= media1 && eleitores >= 20000)
                    {
                        Console.Write("O Candidato 3 venceu. Haverá segundo turno.");
                    }

                    if (media1 > media2 && media2 >= media3 && eleitores <= 20000)
                    {
                        Console.Write("O Candidato 1 venceu. Não Haverá segundo turno.");
                    }
                    if (media2 > media1 && media1 >= media3 && eleitores <= 20000)
                    {
                        Console.Write("O Candidato 2 venceu. Não Haverá segundo turno.");
                    }
                    if (media3 > media2 && media2 >= media1 && eleitores <= 20000)

                    {
                        Console.Write("O Candidato 3 venceu. Não Haverá segundo turno.");
                    }

                }
                








            }


            Console.ReadKey();
        }
    }
}
