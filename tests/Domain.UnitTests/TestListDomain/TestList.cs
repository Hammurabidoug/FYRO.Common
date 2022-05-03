using FYRO.Domain.UnitTests.TestItemDomain;

namespace FYRO.Domain.UnitTests.TestListDomain;
public class TestList : AuditableEntity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public IList<TestItem> Items { get; private set; } = new List<TestItem>();
}
