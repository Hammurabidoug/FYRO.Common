using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYRO.Common.Domain;

namespace FYRO.Common.Domain.UnitTests.TestItemDomain;
public class TestedEvent : DomainEvent
{
    public TestedEvent(TestItem item)
    {
        Item = item;
    }

    public TestItem Item { get; }
}
