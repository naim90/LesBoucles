using System;

namespace Pas_de_Danse
{
    class Program
    {
        static void Main(string[] args)
        {
            int taille = 32;
            string[] moves = new string[taille];
            bool movesAreDone = false;
            int iterator = 0;

            while (!movesAreDone)
            {
                if (iterator < 32)
                {
                    Console.WriteLine("Entre le nom du pas : ");
                    string LePas = Console.ReadLine();

                    if ((LePas == "done") || (LePas=="DONE"))
                    {
                        movesAreDone=true;
                    }
                    else
                    {
                        moves[iterator] = LePas;
                        iterator = iterator + 1;
                    }
                }
                else 
                {
                    break;
                }

            }

            Console.WriteLine("Entrez le nombre de fois que vous voulez faire ces pas : ");
            string nombreDeFois = Console.ReadLine();
            int nombresIterations = Convert.ToInt32(nombreDeFois);

            Console.WriteLine("Allez c'est partie pour faire " + nombresIterations+" fois cette enchaînement !!!!!!\n");

            for (int i=0; i<nombresIterations;i++)
            {

                foreach (string mouvement in moves)
                {

                    if (mouvement !=null)
                    { Console.WriteLine(mouvement); }
                    
                }
                Console.WriteLine("\n");
            }
            
            

        }
    }
}
