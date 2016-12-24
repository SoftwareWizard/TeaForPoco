using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareWizard.TeaForPoco
{
    public class PocoClass
    {
        public string Name { get; set; }

        public IList<string> BaseClasses { get; set; }

        public IList<string> BaseInterfaces { get; set; }

        public IList<PocoProperty> PocoProperties { get; set; }
    }
}
