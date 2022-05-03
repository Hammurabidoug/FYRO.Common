using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYRO.Application.Mappings;
using FYRO.Domain.UnitTests.TestItemDomain;
using FYRO.Domain.UnitTests.TestListDomain;

namespace FYRO.Application.UnitTests.TestDomainList;
public class TestListDTO : IMapFrom<TestList>
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public IList<TestItem>? Items { get; set; }
}
