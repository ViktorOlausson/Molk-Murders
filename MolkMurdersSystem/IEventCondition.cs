using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public interface IEventCondition {
        public bool Check(Character character);
    }
}
