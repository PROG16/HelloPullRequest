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
            persons.Add(new Erik());
            persons.Add(new Daniel());
            persons.Add(new Klas());
            persons.Add(new Andre());
            persons.Add(new Chabbe());
            persons.Add(new Patrik());
            persons.Add(new EsterBergstrom());
            persons.Add(new JesperAndreas());

            persons.Add(new Isa());
            persons.Add(new Tanja());
            foreach (var person in persons)
            {
                person.Speak();
            }
        }
    }
}
