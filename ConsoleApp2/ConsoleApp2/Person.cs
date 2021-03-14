using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Person
    {
        public string namn { get; set; }
        public int ålder { get; set; }
        public string favoritFärg { get; set; }
        public bool gift { get; set; }

        public string Beskrivning(string namn, int ålder, string favoritFärg)
        {
            string presentation = $"Hej jag heter {namn} och är {ålder} gammal, min favoritfärg är {favoritFärg}";
            return presentation;
        }
    }
}
