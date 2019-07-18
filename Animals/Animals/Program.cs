using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Bath bath = new Bath("Batman");
            bath.Fly();
            bath.Walk();
            // bath.Swim();
            //  bath.Crawl();
            Console.WriteLine();
            Dolphin dolphin = new Dolphin("Flipper");
            dolphin.Fly();
            dolphin.Swim();
            // dolphin.Walk();
            //dolphin.Crawl();
            Console.WriteLine();
            Sheep sheep = new Sheep("Shaun");
            sheep.Walk();
            //sheep.Fly();
            // sheep.Swim();
            // sheep.Crawl();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Clownfish clownfish = new Clownfish("Nemo");
            clownfish.Swim();
            //clownfish.Fly();
            //clownfish.Walk();
            // clownfish.Crawl();
            Console.WriteLine();
            Shark shark = new Shark("Bruce");
            shark.Fly();
            shark.Swim();
            //shark.Walk();
            // shark.Crawl();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Canary canary = new Canary("Tweety");
            canary.Fly();
            canary.Walk();
            // canary.Swim();
            //canary.Crawl();
            Console.WriteLine();
            Penguin penguin = new Penguin("Skipper");
            penguin.Walk();
            penguin.Swim();
            // penguin.Fly();
            //penguin.Crawl();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Crocodile crocodile = new Crocodile("Dundee");
            crocodile.Walk();
            crocodile.Swim();
            //crocodile.Fly();
            // crocodile.Crawl();
            Console.WriteLine();
            Snake snake = new Snake("Kaa");
            snake.Crawl();
            // snake.Swim();
            //  snake.Walk();
            //  snake.Fly();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Tarantulla tarantulla = new Tarantulla("Rapunzel");
            tarantulla.Walk();
            // tarantulla.Swim();
            //  tarantulla.Fly();
            //tarantulla.Crawl();
            Console.WriteLine();
            Grasshopper grasshopper = new Grasshopper("Jimminy");
            grasshopper.Walk();
            grasshopper.Fly();
            //  grasshopper.Swim();
            // grasshopper.Crawl();
            Console.WriteLine("---------------------------------------------------------------------------------------");




        }
    }
}
