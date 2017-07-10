﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    class AbstractFactory
    {
        //static void Main(string[] args)
        //{
        //    //abstract fonksiyolar instance alınamaz.
        //    //override edidiliği class ile instance alınabilir.
        //    ContinentFactory africa = new AfricaFactory();
        //    AnimalWorld world = new AnimalWorld(africa);
        //    world.RunFoodChain();

        //    ContinentFactory america = new AmericaFactory();
        //    world = new AnimalWorld(america);
        //    world.RunFoodChain();


        //    Console.ReadKey();
        //}

        abstract class ContinentFactory
        {
            //abstract class içi abstract class olmalıdır. 
            public abstract Herbivore CreateHerbivore();
            public abstract Carnivore CreateCarnivore();
        }

        class AfricaFactory: ContinentFactory
        {
            public override Herbivore CreateHerbivore()
            {
                return new Wildebeest();
            }
            public override Carnivore CreateCarnivore()
            {
                return new Lion();
            }
        }

        class AmericaFactory: ContinentFactory
        {
            public override Herbivore CreateHerbivore()
            {
                return new Bison();
            }

            public override Carnivore CreateCarnivore()
            {
                return new Wolf();
            }
        }


        abstract class Herbivore
        {

        }

        abstract class Carnivore
        {
            public abstract void Eat(Herbivore h);
        }

        class Wildebeest : Herbivore
        {

        }

        class Lion: Carnivore
        {
            public override void Eat(Herbivore h)
            {
                Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
            }
        }

        class  Bison: Herbivore
        {

        }

        class Wolf : Carnivore
        {
            public override void Eat(Herbivore h)
            {
                Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);

            }
        }


        class AnimalWorld
        {
            private Herbivore _herbivore;
            private Carnivore _carnivore;

            public AnimalWorld(ContinentFactory factory)
            {
                _carnivore = factory.CreateCarnivore();
                _herbivore = factory.CreateHerbivore();
            }
            public void RunFoodChain()
            {
                _carnivore.Eat(_herbivore);
            }
        }
    }
}
