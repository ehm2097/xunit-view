using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avat.XUnitView
{
    interface IResultNode
    {
        string Name { get; }
        TestOutcomes Outcome { get; }
        string OutputText { get; }
        string FailTypeName { get; }
        string FailText { get; }
        string FailStack { get; }
        IEnumerable<IResultNode> Subnodes { get; }
    }
}
