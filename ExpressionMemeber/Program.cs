﻿using System;
using System.Collections.Generic;

namespace ExpressionMemeber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Place holder");
            Console.ReadLine();
        }

        public class Bug
{
    /*
        You can declare a typed public property, make it read-only,
        and initialize it with a default value all on the same
        line of code in C#. Readonly properties can be set in the
        class' constructors, but not by external code.
    */
    public string Name { get; } = "";
    public string Species { get; } = "";
    public ICollection<string> Predators { get; } = new List<string>();
    public ICollection<string> Prey { get; } = new List<string>();

    // Convert this readonly property to an expression member
   

    public string FormalName => Name + " " + Species;

    // Class constructor
    public Bug(string name, string species, List<string> predators, List<string> prey)
    {
        this.Name = name;
        this.Species = species;
        this.Predators = predators;
        this.Prey = prey;
    }

    // Convert this method to an expression member
    

    public string PreyList() => "," + Prey;

    // Convert this method to an expression member
   

    public string PredatorList() => "," + Predators;

    // Convert this to expression method (hint: use a C# ternary)
    public string Eat(string food)
    {
        if (this.Prey.Contains(food))
        {
            return $"{this.Name} ate the {food}.";
        } else {
            return $"{this.Name} is still hungry.";
        }
    }
}
    }
}
