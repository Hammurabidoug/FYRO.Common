using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYRO.Common.Application.Mappings;
using FYRO.Common.Domain.UnitTests.TestItemDomain;
using FYRO.Common.Domain.UnitTests.TestListDomain;

namespace FYRO.Common.Application.UnitTests.TestDomainList;
public class TestListDTO : IMapFrom<TestList>
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public IList<TestItem>? Items { get; set; }
}
