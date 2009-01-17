using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Timesheet.Domain.Test.Presentation
{
    [TestFixture]
    public class PredicateTest
    {
        [Test]
        public void test_predicate_and_action()
        {
            var animals = GetAnimals();
            Predicate<Animal> animalsStartingWithL = a => a.Name.StartsWith("L");
            Action<Animal> printAnimal = a => Console.WriteLine(a);

            Console.WriteLine("All animals:");
            animals.ForEach(printAnimal);
            Console.WriteLine();
            Console.WriteLine("Animals starting with an L:");
            animals.FindAll(animalsStartingWithL).ForEach(printAnimal);
        }

        private List<Animal> GetAnimals()
        {
            var animals = new List<Animal>
                              {
                                  new Animal("Lassie"),
                                  new Animal("Kermit")
                              };
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