using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FYRO.Application.Mappings;
using FYRO.Domain.UnitTests.TestItemDomain;

namespace FYRO.Application.UnitTests.TestItemDomain;
public class TestItemDTO : IMapFrom<TestItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Name { get; set; }
}
