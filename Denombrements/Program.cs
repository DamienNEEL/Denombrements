﻿/**
 * Application "denombrements"
 * author : Albert
 * date : 14/10/2021
 */
using System;


namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration
            int c = 1;
            bool correct = false;

            while (correct == false) 
                {
                try
                {
                    while (c != 0)
                    {
                        Console.WriteLine("Permutation ...................... 1");
                        Console.WriteLine("Arrangement ...................... 2");
                        Console.WriteLine("Combinaison ...................... 3");
                        Console.WriteLine("Quitter .......................... 0");
                        Console.Write("Choix :                            ");
                        c = int.Parse(Console.ReadLine());

                        if (c == 0) { Environment.Exit(0); }

                        if (c == 1)
                        {
                            // le nombre d'éléments à gérer
                            Console.Write("nombre total d'éléments à gérer = ");
                            // saisir le nombre
                            int n = int.Parse(Console.ReadLine());
                            // calcul de r
                            long r = 1;
                            for (int k = 1; k <= n; k++)
                                r *= k;
                            Console.WriteLine(n + "! = " + r);
                        }
                        if (c == 2)
                        {
                                                        
                             // le nombre d'éléments à gérer
                             Console.Write("nombre total d'éléments à gérer = ");
                             // saisir le nombre
                             int t = int.Parse(Console.ReadLine());
                             // le sous ensemble
                             Console.Write("nombre d'éléments dans le sous ensemble = ");
                             // saisir le nombre
                             int n = int.Parse(Console.ReadLine());
                             // calcul de r
                             long r = 1;
                             for (int k = (t - n + 1); k <= t; k++)
                             r *= k;
                             //affichage du résultat;
                             Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                        }
                        if (c ==3)
                        {

                            
                             // le nombre d'éléments à gérer
                             Console.Write("nombre total d'éléments à gérer = ");
                             // saisir le nombre
                             int t = int.Parse(Console.ReadLine());
                             // le sous ensemble
                             Console.Write("nombre d'éléments dans le sous ensemble = ");
                             // saisir le nombre
                             int n = int.Parse(Console.ReadLine());
                             // calcul de r1
                             long r1 = 1;
                             for (int k = (t - n + 1); k <= t; k++)
                             r1 *= k;
                             // calcul de r2
                             long r2 = 1;
                             for (int k = 1; k <= n; k++)
                             r2 *= k;
                             //affichage du résultat
                             Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        }
                        if ( c != 1 && c != 2 && c != 3)
                        {
                            Console.WriteLine("Entrez un entier présent dans le menu");
                        }
                        
                    }
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Entrez un entier");
                }
                
            }
            
        }
    }
}
