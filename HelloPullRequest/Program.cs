﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPullRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            persons.Add(new Fredrik());
            persons.Add(new JesperAndreas());
            persons.Add(new EsterBergstrom());

            foreach (var person in persons)
            {
                person.Speak();
            }
        }
    }
}
