using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Bat bat = new Bat("Batman", 76, 5);
            bat.Fly();
            bat.Walk();
            // bat.Swim();
            //  bat.Crawl();
            Console.WriteLine();
            Dolphin dolphin = new Dolphin("Flipper", 60, 26);
            dolphin.Fly();
            dolphin.Swim();
            // dolphin.Walk();
            //dolphin.Crawl();
            Console.WriteLine();
            Sheep sheep = new Sheep("Shaun", 15);
            sheep.Walk();
            //sheep.Fly();
            // sheep.Swim();
            // sheep.Crawl();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Clownfish clownfish = new Clownfish("Nemo", 20);
            clownfish.Swim();
            //clownfish.Fly();
            //clownfish.Walk();
            // clownfish.Crawl();
            Console.WriteLine();
            Shark shark = new Shark("Bruce", 30, 15);
            shark.Fly();
            shark.Swim();
            //shark.Walk();
            // shark.Crawl();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Canary canary = new Canary("Tweety", 46, 12);
            canary.Fly();
            canary.Walk();
            // canary.Swim();
            //canary.Crawl();
            Console.WriteLine();
            Penguin penguin = new Penguin("Skipper", 30, 3);
            penguin.Walk();
            penguin.Swim();
            // penguin.Fly();
            //penguin.Crawl();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Crocodile crocodile = new Crocodile("Dundee", 5, 26);
            crocodile.Walk();
            crocodile.Swim();
            //crocodile.Fly();
            // crocodile.Crawl();
            Console.WriteLine();
            Snake snake = new Snake("Kaa", 15);
            snake.Crawl();
            // snake.Swim();
            //  snake.Walk();
            //  snake.Fly();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Tarantulla tarantulla = new Tarantulla("Rapunzel", 15);
            tarantulla.Walk();
            // tarantulla.Swim();
            //  tarantulla.Fly();
            //tarantulla.Crawl();
            Console.WriteLine();
            Grasshopper grasshopper = new Grasshopper("Jimminy", 30, 8);
            grasshopper.Walk();
            grasshopper.Fly();
            //  grasshopper.Swim();
            // grasshopper.Crawl();
            Console.WriteLine("---------------------------------------------------------------------------------------");




        }
    }
}
