using WebApplication3.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Data.interfaces
{
    public interface ICarsCetegore
    {
        IEnumerable<Kategor> AllCategory { get; }
    }
}
