using AnnotationsAndGarbage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotationsandgarbage
{
    internal class Employer
    {
        int id;
        string name;
        public Employer(int i, string n)
        {
            id = i;
            name = n;
        }
        [NewAttribute("Accessor", "Gives value of Employer Id")]
        public int getId()
        {
            return id;
        }
        [NewAttribute("Accessor", "Gives value of Employer Name")]
        public string getName()
        {
            return name;
        }
    }
}

