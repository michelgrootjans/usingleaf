using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Timesheet.Domain.Test.Presentation
{
    [TestFixture]
    public class PredicateTest
    {
        [Test]
        public void lmkqsjdfmlkjqsdf()
        {
            var animals = GetAnimals();
            Predicate<Animal> animalsStartingWithL = a => a.Name.StartsWith("L");
            Action<Animal> printAnimal = a => Console.WriteLine(a);

            animals.FindAll(animalsStartingWithL).ForEach(printAnimal);
        }

        private List<Animal> GetAnimals()
        {
            var animals = new List<Animal>();
            animals.Add(new Animal("Lassie"));
            animals.Add(new Animal("Kermit"));
            return animals;
        }
    }

    internal class Animal
    {
        public readonly string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("Animal: {0}", Name);
        }
    }
}