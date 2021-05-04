using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Data.model{
    public class Car
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesk { set; get; }

        public string longDesc { set; get; }

        public string img { set; get; }

        public ushort prise { set; get; }

        public bool isFavorite { set; get; }

        public int available { set; get; }

        public int categoriId { set; get; }

        public virtual Kategor Category { set; get; }

    }
}
