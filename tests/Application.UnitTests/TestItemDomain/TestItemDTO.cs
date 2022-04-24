using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FYRO.Common.Application.Mappings;
using FYRO.Common.Domain.UnitTests.TestItemDomain;

namespace FYRO.Common.Application.UnitTests.TestItemDomain;
public class TestItemDTO : IMapFrom<TestItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Name { get; set; }
}
