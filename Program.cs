using System;
using System.Threading.Tasks;

namespace BreakFAST
{
    class Program
    {
        
        static async Task Main()
        {
            await (MakeBreakfastAsync());
        }

        public static async Task<string> MakeBreakfastAsync()
        {
            Console.WriteLine("Start to cook breakfast!");

            var fryingEggs = FryEggsAsync(2);

            var fryingBread = FryBreadSlicesAsync(2);

            var cuttedMushroom = CutMushroom(5);

            var friedMushroom = await FryMushroomAsync();

            var friedEggs = await fryingEggs;

            var friedBread = await fryingBread;

            var breakfast = "Breakfast ready! Have a nice meal";

            Console.WriteLine("Breakfast ready! Have a nice meal");

            return breakfast;
        }

        public static async Task<string> FryEggsAsync(int x)
        {
            Console.WriteLine("Frying eggs");

            await Task.Delay(1000);

            Console.WriteLine($"{x} fried eggs");

            return $"{x} fried eggs";
        }

        public static string CutMushroom(int x)
        {
            Console.WriteLine("Cutting mushrooms");

            Task.Delay(500).GetAwaiter().GetResult();

            Console.WriteLine($"{x} cutted mushrooms");

            return $"{x} cutted mushrooms";
        }

        public static async Task<string> FryMushroomAsync()
        {
            Console.WriteLine($"Frying cutted mushrooms");

            await Task.Delay(3000);

            Console.WriteLine("Mushrooms fried");

            return $"Mushrooms fried";

        }

        public static async Task<string> FryBreadSlicesAsync(int x)
        {
            Console.WriteLine("Toasting bread");

            await Task.Delay(2000);

            Console.WriteLine($"{x} slices of bread fried");

            return $"{x} slices of bread fried";
        }
    }
}

        