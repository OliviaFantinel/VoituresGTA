namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{

    static void DisplayCars(string[] cars)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine($"{i+1}. {cars[i]}");
        }
    }
    
    static void Main(string[] args)
    {
        string[] cars =
        {
            "Banshee",
            "Zentorno",
            "Sultan",
            "Sanchez",
            "Buzzard"
        };
        DisplayCars(cars);
        Console.WriteLine("Which car do you want to change? 1-5");
        int carNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You chose to replace {cars[carNumber-1]}");
        Console.WriteLine("What's the car you want to replace it with?");
        string newCar = Console.ReadLine();
        cars[carNumber-1] = newCar;
        DisplayCars(cars);
    }
}