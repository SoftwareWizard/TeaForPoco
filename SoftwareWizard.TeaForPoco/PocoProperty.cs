using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SoftwareWizard.TeaForPoco
{
    public class PocoProperty
    {
        public string Name { get; set; }

        public TypeSyntax TypeSyntax { get; set; }
    }
}
