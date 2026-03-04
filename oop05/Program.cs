using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            #region question1
            //What is an Interface in C#?
            //An interface in C# is a reference type that defines a contract (a set of methods, properties, events, or indexers) 
            //that a class must implement.
            //It contains only declarations, not implementation

            //Why Do We Use Interfaces Instead of Depending on Concrete Classes ?
            //Achieve loose coupling
            //Improve testability
            //Support extensibility
            //Follow SOLID principles

            //Mention at least three benefits of using interfaces:
            //1-Loose Coupling
            //2- Better Testability(Mocking)
            //3- Extensibility(Open / Closed Principle)

            #endregion
            #region question2
            // a) What is the problem with this design? Both interfaces have a method called Greet() — how does the class handle it currently
            //The Problem:
            //We cannot provide different behavior for each interface, even though logically:
            //IEnglishSpeaker.Greet() should say "Hello"
            //IArabicSpeaker.Greet() should say "Ahlan"
            //Right now, both use the same method.

            // b) How do we fix it ?
            //We use Explicit Interface Implementation.


         //   c) Can we call translator.Greet() directly ?
         //  No, we cannot.
         //  Why?
         // Because explicit interface methods :
         //Are not public
         //Are only accessible through the interface reference

        // How to call each version?

        // Translator translator = new Translator();

        //IEnglishSpeaker english = translator;

        //english.Greet();   // Prints: Hello

        // IArabicSpeaker arabic = translator;

        //arabic.Greet();    // Prints: Ahlan
            #endregion

            #endregion

        }
    }
}
