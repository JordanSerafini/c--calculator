using System;

class Calculatrice
{
    static void Main()
    {
        Console.WriteLine("Calculatrice en C#");
        
        while (true)
        {
            Console.Write("Entrez le premier nombre: ");
            double nombre1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Entrez l'opérateur (+, -, *, /): ");
            char operateur = Convert.ToChar(Console.ReadLine());
            
            Console.Write("Entrez le second nombre: ");
            double nombre2 = Convert.ToDouble(Console.ReadLine());

            double resultat;

            switch (operateur)
            {
                case '+':
                    resultat = nombre1 + nombre2;
                    break;
                case '-':
                    resultat = nombre1 - nombre2;
                    break;
                case '*':
                    resultat = nombre1 * nombre2;
                    break;
                case '/':
                    if (nombre2 != 0)
                    {
                        resultat = nombre1 / nombre2;
                    }
                    else
                    {
                        Console.WriteLine("Division par zéro non autorisée.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Opérateur invalide.");
                    continue;
            }

            Console.WriteLine($"Résultat: {resultat}");
            Console.WriteLine("Tapez 'exit' pour sortir ou appuyez sur Entrée pour continuer.");
            if (Console.ReadLine() == "exit") break;
        }
    }
}
