using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Fat_Secret_MVVM.Model
{
    internal class Mymodel
    {
        public Mymodel(string n, string nam, int c) {
            number = n;
            name = nam;
            calories = c;
        }

        public string number { get; set; }
        public string name { get; set; }
        public int calories { get; set; }
    }
}
