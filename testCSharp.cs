//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public abstract class Employee
    {
        public abstract Employee Clone();

        public string Name { get; set; }
        public string Role { get; set; }
    }


    public class Typist : Employee
    {
        public int WordsPerMinute { get; set; }

        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}wpm", Name, Role, WordsPerMinute);
        }
    }


    public class Developer : Employee
    {
        public string PreferredLanguage { get; set; }

        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Name, Role, PreferredLanguage);
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {   
            Developer dev = new Developer();
            dev.Name = "Bob";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Sue";

            Console.WriteLine(dev);
            Console.WriteLine(devCopy);

            Typist typist = new Typist();
            typist.Name = "Kay";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Tim";
            typistCopy.WordsPerMinute = 115;

            Console.WriteLine(typist);
            Console.WriteLine(typistCopy);
        }
    }
}
