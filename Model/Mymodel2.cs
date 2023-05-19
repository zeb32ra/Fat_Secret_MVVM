using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat_Secret_MVVM.Model
{
    internal class Mymodel2
    {
        public string date;
        public List<Mymodel> list;

        public Mymodel2(string d, List<Mymodel> l) {
            date = d;
            list = l;
        }
    }
}
