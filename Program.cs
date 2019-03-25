﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexT {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello world");
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12345";
            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine($"{matchCollection.Count} hits found:\n {text}");

            foreach (Match hit in matchCollection) {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            }
            Console.ReadLine();
        }
    }
}
