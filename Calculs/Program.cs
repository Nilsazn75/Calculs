﻿using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution = 0; // calcul de la solution
            int reponse = 0; // saisie de la réponse de l'utilisateur
            int choix = 1; // saisie du choix de l'utilsiateur
            bool correct;

            // boucle sur le menu
            
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Vous n'avez pas saisi un entier entre 0 et 2");
                        correct = false;
                    }
                }
                
                // traitement des choix
                
                
                if (choix != 0)
                {
                    val1 = rand.Next(1, 10);
                    val2 = rand.Next(1, 10);
                    if (choix == 1)
                    {
                        // choix de l'addition
                        
                        // saisie de la réponse
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier et pas de lettre !");
                                correct = false;
                            }
                        }

                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else if (choix == 2)
                    {
                        // choix de la multiplication
                        
                        // saisie de la réponse
                        
                        correct = false;
                        while(!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisi : saisissez un chiffre/nombre, pas de lettre");
                                correct = false;
                            }
                        }
                        
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Saisissez un chiffre entre 0 et 2 .");
                    }
                }
            }
        }
    }
}
