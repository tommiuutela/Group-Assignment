using System;
using System.Collections;
using System.Collections.Generic;

namespace groupassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();
            animals.Add("Bear");
            animals.Add("Wolf");
            animals.Add("Tiger");
            animals.Add("Cat");
            animals.Add("Dog");
            animals.Add("Bird");
            Animal Bear = new Animal(true, "Otso", "ROAR!", "Bear doesn't give a F.", "none", 276.5);
            Animal Wolf = new Animal(true, "Fenrir", "HOWL!", "Wolf yawns", "none", 56.2);
            Animal Tiger = new Animal(true, "Chubby", "HISS!", "Tiger sits down.", "none", 96.5);
            Animal Cat = new Animal(true, "Ragnar", "MEOW!", "''purr'' cat came to owner.", "Ahmed Abdullah", 4);
            Animal Dog = new Animal(true, "Bingo", "BARK!", "Dog came to owner.", "Lil Ali", 9);
            Animal Bird = new Animal(true, "Acanthis", "CAW CAW!", "Bird cant understand human.", "Blackbeard", 0.2);
            bool looping = true;
            Console.WriteLine("What do you want to do? [list, quit]");
            string answer = Console.ReadLine();
            start:
            while (looping == true)
            {
                if (answer == "list")
                {
                    start2:
                    animals.ForEach(Console.WriteLine);
                    Console.WriteLine("Which animal do you want to see?");
                    answer = Console.ReadLine();
                    if (answer == "quit")
                    {
                        looping = false;
                        goto start;
                    }
                    if (answer.Equals("BEAR", StringComparison.InvariantCultureIgnoreCase) ||
                        answer.Equals("WOLF", StringComparison.InvariantCultureIgnoreCase) ||
                        answer.Equals("TIGER", StringComparison.InvariantCultureIgnoreCase) ||
                        answer.Equals("CAT", StringComparison.InvariantCultureIgnoreCase) ||
                        answer.Equals("DOG", StringComparison.InvariantCultureIgnoreCase) ||
                        answer.Equals("BIRD", StringComparison.InvariantCultureIgnoreCase))
                    {
                        string currentAnimal = answer;
                        if (currentAnimal.Equals("WOLF", StringComparison.InvariantCultureIgnoreCase) ||
                            currentAnimal.Equals("BEAR", StringComparison.InvariantCultureIgnoreCase) ||
                            currentAnimal.Equals("TIGER", StringComparison.InvariantCultureIgnoreCase))
                        {
                            start3:
                            Console.WriteLine("What do you want to do? [Hunt, MakeSound, ComeHere, GiveName, back, quit]");
                            answer = Console.ReadLine();

                            if (answer.Equals("hunt", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("makesound", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("ComeHere", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("GiveName", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("back", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("quit", StringComparison.InvariantCultureIgnoreCase)
                                )
                            {
                                if (answer.Equals("makesound", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    if (currentAnimal.Equals("BEAR", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Bear.MakeSound();
                                        goto start3;
                                    }
                                    else if (currentAnimal.Equals("WOLF", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Wolf.MakeSound();
                                        goto start3;
                                    }
                                    else if (currentAnimal.Equals("TIGER", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Tiger.MakeSound();
                                        goto start3;
                                    }
                                }
                                if (answer.Equals("Hunt", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    if (currentAnimal.Equals("BEAR", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Bear.Hunt();
                                        goto start3;
                                    }
                                    else if (currentAnimal.Equals("WOLF", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Wolf.Hunt();
                                        goto start3;
                                    }
                                    else if (currentAnimal.Equals("TIGER", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Tiger.Hunt();
                                        goto start3;
                                    }
                                }
                                if (answer.Equals("ComeHere", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    if (currentAnimal.Equals("BEAR", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Bear.ComeHere();
                                        goto start3;
                                    }
                                    else if (currentAnimal.Equals("WOLF", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Wolf.ComeHere();
                                        goto start3;
                                    }
                                    else if (currentAnimal.Equals("TIGER", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Tiger.ComeHere();
                                        goto start3;
                                    }
                                }
                                if (answer.Equals("GiveName", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    if (currentAnimal.Equals("BEAR", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Bear.GiveName();
                                        goto start3;
                                    }
                                    else if (currentAnimal.Equals("WOLF", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Wolf.GiveName();
                                        goto start3;
                                    }
                                    else if (currentAnimal.Equals("TIGER", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Tiger.GiveName();
                                        goto start3;
                                    }
                                }
                                if (answer.Equals("back", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    goto start2;
                                }
                                if (answer.Equals("quit", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    goto stop;
                                }
                            }
                            Console.WriteLine("ERROR! Please input command you want to execute.");
                            goto start3;
                        }
                        if (currentAnimal.Equals("CAT", StringComparison.InvariantCultureIgnoreCase) ||
                            currentAnimal.Equals("DOG", StringComparison.InvariantCultureIgnoreCase) ||
                            currentAnimal.Equals("BIRD", StringComparison.InvariantCultureIgnoreCase))
                        {
                            start3:
                            Console.WriteLine("What do you want to do? [Feed, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]");
                            answer = Console.ReadLine();
                            if (answer.Equals("feed", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("makesound", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("ComeHere", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("GiveName", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("talktoowner", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("back", StringComparison.InvariantCultureIgnoreCase) ||
                                answer.Equals("quit", StringComparison.InvariantCultureIgnoreCase)
                                )
                            {
                                if (answer.Equals("talktoowner", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    if (currentAnimal.Equals("CAT", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Cat.OwnerTalk();
                                        goto start3;
                                    }
                                    else if (currentAnimal.Equals("DOG", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Dog.OwnerTalk();
                                        goto start3;
                                    }
                                    else if (currentAnimal.Equals("BIRD", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        Bird.OwnerTalk();
                                        goto start3;
                                    }
                                }
                                    if (answer.Equals("makesound", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        if (currentAnimal.Equals("CAT", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Cat.MakeSound();
                                            goto start3;
                                        }
                                        else if (currentAnimal.Equals("DOG", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Dog.MakeSound();
                                            goto start3;
                                        }
                                        else if (currentAnimal.Equals("BIRD", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Bird.MakeSound();
                                            goto start3;
                                        }
                                    }
                                    if (answer.Equals("feed", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        if (currentAnimal.Equals("CAT", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Cat.Feed();
                                            goto start3;
                                        }
                                        else if (currentAnimal.Equals("DOG", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Dog.Feed();
                                            goto start3;
                                        }
                                        else if (currentAnimal.Equals("BIRD", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Bird.Feed();
                                            goto start3;
                                        }
                                    }
                                    if (answer.Equals("ComeHere", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        if (currentAnimal.Equals("CAT", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Cat.ComeHere();
                                            goto start3;
                                        }
                                        else if (currentAnimal.Equals("DOG", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Dog.ComeHere();
                                            goto start3;
                                        }
                                        else if (currentAnimal.Equals("BIRD", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Bird.ComeHere();
                                            goto start3;
                                        }
                                    }
                                    if (answer.Equals("GiveName", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        if (currentAnimal.Equals("CAT", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Cat.GiveName();
                                            goto start3;
                                        }
                                        else if (currentAnimal.Equals("DOG", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Dog.GiveName();
                                            goto start3;
                                        }
                                        else if (currentAnimal.Equals("BIRD", StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            Bird.GiveName();
                                            goto start3;
                                        }
                                    }
                                    if (answer.Equals("back", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        goto start2;

                                    }
                                    if (answer.Equals("quit", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        goto stop;
                                    }
                                }
                            Console.WriteLine("ERROR! Please input command you want to execute.");
                            goto start3;
                        }                           
                        }
                    Console.WriteLine("ERROR! Please input animal you want to see.");
                    goto start2;
                }
                stop:
                if (answer == "quit")
                {
                    looping = false;
                    goto start;
                }
                else
                {
                    Console.WriteLine("ERROR!");
                    Console.WriteLine("What do you want to do? [list, quit]");
                    answer = Console.ReadLine();
                    goto start;
                }
          
            }        
            }
        }
        class Animal
        {
            public bool Wild;
            public string Name;
            public string Sound;
            public string Come;
            public string OwnerName;
            public double Weight;


            public Animal(bool wild, string thisName, string thisSound, string thisCome, string thisOwnerName, double thisWeight)
            {
                this.Wild = wild;
                this.Name = thisName;
                this.Sound = thisSound;
                this.Come = thisCome;
                this.OwnerName = thisOwnerName;
                this.Weight = thisWeight;
            }
            public string GiveName()
            {
                this.Name = Console.ReadLine();
                Console.WriteLine("You change the name to: " + this.Name);
                return this.Name;
            }
            public void Hunt()
            {
                System.Random random = new System.Random();
                int chance = random.Next(101);
                if (chance > 40)
                {
                    Console.WriteLine(Name + "s" + " hunt was succesful and he gains 1kg of weight!");
                    this.Weight++;
                    Console.WriteLine(this.Name + " weighs " + this.Weight + " kilograms.");
            }
                else
                {
                    Console.WriteLine(Name + "s " + "Hunt failed!");
                }
            }
            public void MakeSound()
            {
                Console.WriteLine(Name + ": " + Sound);
            }
            public void ComeHere()
            {
                Console.WriteLine(Come);
            }
            public void OwnerTalk()
            {
                Console.WriteLine("Hi " + this.OwnerName + ", how are you?");
                Console.WriteLine(this.OwnerName + ": ''deep silence''");
            }
            public void Feed()
            {
                Console.WriteLine("You feed " + this.Name + " and he gains 1kg of weight.");
            this.Weight++;
                Console.WriteLine(this.Name + " weighs " + this.Weight + " kilograms.");
            }
        }
    }



