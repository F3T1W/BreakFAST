using System;
using System.Threading.Tasks;

namespace BreakFAST
{
    class Program
    {
        
        static void Main()
        {
             MakeBreakfastAsync();
        }

        public static void MakeBreakfastAsync()
        {
            Console.WriteLine("Start to cook breakfast!");

            var fryingEggs = FryEggsAsync(2);

            var fryingBread = FryBreadSlicesAsync(2);

            CutMushroom(5);

            var friedMushroom =  FryMushroomAsync();

            Task.WaitAll(fryingEggs, fryingBread, friedMushroom);

            Console.WriteLine("Breakfast ready! Have a nice meal");
        }

        public static async Task FryEggsAsync(int x)
        {
            Console.WriteLine("Frying eggs");

            await Task.Delay(1000);

            Console.WriteLine($"{x} fried eggs");
        }

        public static void CutMushroom(int x)
        {
            Console.WriteLine("Cutting mushrooms");

            Task.Delay(500).GetAwaiter().GetResult();

            Console.WriteLine($"{x} cutted mushrooms");

        }

        public static async Task FryMushroomAsync()
        {
            Console.WriteLine($"Frying cutted mushrooms");

            await Task.Delay(3000);

            Console.WriteLine("Mushrooms fried");
        }

        public static async Task FryBreadSlicesAsync(int x)
        {
            Console.WriteLine("Toasting bread");

            await Task.Delay(2000);

            Console.WriteLine($"{x} slices of bread fried");
        }
    }
}

        