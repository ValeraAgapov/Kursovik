using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Data.model
{
    public class Kategor{
        public int id { set; get;}

        public string name { set; get; }

        public string desk { set; get; }

        public List<Car> cars { set; get; }

    }
}
