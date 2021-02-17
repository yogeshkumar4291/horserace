using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horserace
{
    public static class Factory
    {
        public static Punter GetAPunter(string classname)
        {
            if (classname.Equals("Yogesh"))
            {
                return new Yogesh() { Name = "Yogesh", Cash = 50 };
            }
            else if (classname.Equals("Avi"))
            {
                return new Avi() { Name = "Avi", Cash = 50 };
            }
            else if (classname.Equals("Gourav"))
            {
                return new Gourav() { Name = "Gourav", Cash = 50 };
            }
            else
            {
                return null;
            }
        }
    }
}
