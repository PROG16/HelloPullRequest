using System;
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
            persons.Add(new Andre());
            persons.Add(new Chabbe());
            persons.Add(new Patrik());
            persons.Add(new EsterBergstrom());
            persons.Add(new JesperAndreas());

            foreach (var person in persons)
            {
                person.Speak();
            }
            Console.ReadKey();
        }
    }
}
