using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System.Threading.Channels;
using System.Xml.Linq;
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
            #region question3
            //Difference Between Shallow Copy and Deep Copy
            //1-Shallow Copy:
            //A shallow copy creates a new object, but:
            //Value - type fields: copied normally(new independent values)
            //Reference - type fields: the reference(address) is copied, not the actual object
            //So both objects point to the same referenced object in memory.

            //2-Deep Copy:
            //A deep copy creates a completely independent copy:
            //Value - type fields → copied
            //Reference - type fields → new objects are created
            //So the copied object does NOT share any internal references with the original.
            //Each object is fully independent.

            // When Do We Use Each One?
            //Use Shallow Copy When:
            //The object contains only value types
            //Or reference fields are immutable(like string)
            //Or you intentionally want shared references
            //For performance(it’s faster and uses less memory)

            //Use Deep Copy When:
            //The object contains mutable reference-type fields
            //You want a completely independent object
            //You don’t want changes in one object to affect the other

            //What Is the Risk of Using Shallow Copy with Reference-Type Fields?
            //The main risk is:
            //Unintended side effects.
            //If both objects share the same referenced object, modifying it in one object will affect the other.
            #endregion

            #endregion

        }
    }
}
