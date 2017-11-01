using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPullRequest
{
    public class Fredrik : Person
    {
        public override bool CanSpeak()
        {
            return true;
        }

        public override void Speak()
        {
            Console.WriteLine("Khalid was here!");
        }
    }
}
