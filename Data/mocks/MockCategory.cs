using WebApplication3.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data.model;

namespace WebApplication3.Data.mocks {
    public class MockCategory : ICarsCetegore {
        public IEnumerable<Kategor> AllCategory {
            get {
                return new List<Kategor> {
                    new Kategor {name = "Студенты первых курсов", desk = "Названия курсов"},
                    new Kategor {name = "Студенты вторых курсов", desk = "Названия курсов"},
                    new Kategor {name = "Студенты третих курсов", desk = "Названия курсов"},
                    new Kategor {name = "Студенты четвёртых курсов", desk = "Названия курсов"},
                };
            }
        }
    }
}
