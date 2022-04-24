using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYRO.Common.Domain.UnitTests.TestListDomain;

namespace FYRO.Common.Domain.UnitTests.TestItemDomain;
public class TestItem : AuditableEntity, IHasDomainEvent
{
    private bool tested;

    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Name { get; set; }

    public bool Tested
    {
        get => tested;
        set
        {
            if (value == true && tested == false)
            {
                DomainEvents.Add(new TestedEvent(this));
            }

            tested = value;
        }
    }

    public TestList SubList { get; set; } = null!;

    public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
}
