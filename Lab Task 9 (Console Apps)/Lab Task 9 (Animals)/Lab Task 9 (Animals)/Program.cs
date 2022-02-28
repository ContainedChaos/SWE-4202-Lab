using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_9__Animals_
{
    public class Animal
    {
        string nameOfAnimal;
        string habitat_area;
        string sound;
        int weight;
        int height;
        public int birthYear = 2021;

        public string NameOfAnimal
        {
            get { return nameOfAnimal; }
            set { nameOfAnimal = value; }
        }

        public string HabitatArea
        {
            get { return habitat_area; }
            set { habitat_area = value; }
        }

        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int getAge()
        {
            return 2022 - birthYear;
        }

        public string Vocalize()
        {
            return sound;
        }

        public string getInformation()
        {
            return ("Name: " + NameOfAnimal + "\nHabitat: " + HabitatArea + "\nWeight: " + Weight + "\nHeight: " + Height + "\nAge: " + getAge());
        }
    }

    public class Cat : Animal
    {
        public Cat ()
        {
            NameOfAnimal = "Cat";
            HabitatArea = "Homes, streets, IUT halls of residence and field, etc.";
            Sound = "Meow";
            Weight = 5;
            Height = 15;
        }
    }

    public class Cow : Animal
    {
        public Cow()
        {
            NameOfAnimal = "Cow";
            HabitatArea = "Farms, grassy meadows, homes, forests, etc.";
            Sound = "Moo";
            Weight = 130;
            Height = 200;
            birthYear = 2018;
        }
    }

    public class Chicken : Animal
    {
        public Chicken()
        {
            NameOfAnimal = "Chicken";
            HabitatArea = "Homes, village areas, farms, etc.";
            Sound = "Buck Buck";
            Weight = 2;
            Height = 10;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cat

            Cat kitty = new Cat();

            Console.WriteLine("\n------------Cat-----------");
            Console.WriteLine("Sound: " + kitty.Vocalize());
            Console.WriteLine(kitty.getInformation());

            //Cow

            Cow bull = new Cow();

            Console.WriteLine("\n------------Cow-----------");
            Console.WriteLine("Sound: " + bull.Vocalize());
            Console.WriteLine(bull.getInformation());

            //Chicken

            Chicken chimken = new Chicken();

            Console.WriteLine("\n------------Chicken-----------");
            Console.WriteLine("Sound: " + chimken.Vocalize());
            Console.WriteLine(chimken.getInformation());

            Console.ReadKey();
        }
    }
}
