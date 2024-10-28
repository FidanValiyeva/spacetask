using System;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool f = false;
            string choice;

            double planetId;
            string name;
            double area;

            do
            {
                Console.WriteLine("1.planet yarat 2.Butun Planetleri gor 3.Planet sec (planetin adini daxil ederek secilecek) 0.Exit");

                choice = Console.ReadLine();

               

                switch (choice)
                {
                    case "1":
                     Console.WriteLine("planet adi daxil et");
                     name=Console.ReadLine();
                     Planet planet = new Planet(name);
                     AppDbContext.CreatePlanet(planet);

                        bool isId=false;
                        do
                        {
                            Console.WriteLine("planet idsi daxil et");
                            isId = double.TryParse(Console.ReadLine(),out planetId);

                        }while(!isId);

                        bool isArea=false;
                        do
                        {
                            Console.WriteLine("planet sahesi daxil et ");
                            isArea=double.TryParse(Console.ReadLine(),out planetId);
                        } while(!isArea);

                        case "2":
                        List<Planet> planets = AppDbContext.GetAllPlanets();
                        foreach (var item in planets)
                        {
                            Console.WriteLine(item.planet);
                        }

                        break;
                        case "3":
                        break;
                    case "0":
                        break;

                        choice = Console.ReadLine();
                        do
                        {

                            switch (choice)
                            {
                                case "1":

                                    break;
                            }
                        } while (true);


                    break;
                    default:
                        break;
                }

            }while (!f);
        }
    }
}