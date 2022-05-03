using System.Runtime.Serialization;
using AutoMapper;
using FYRO.Application.Mappings;
using FYRO.Application.UnitTests.TestDomainList;
using FYRO.Application.UnitTests.TestItemDomain;
using FYRO.Domain.UnitTests.TestItemDomain;
using FYRO.Domain.UnitTests.TestListDomain;
using NUnit.Framework;

namespace FYRO.Application.UnitTests.Mappings;

public class MappingTests
{
    private readonly IConfigurationProvider _configuration;
    private readonly IMapper _mapper;

    public MappingTests()
    {
        _configuration = new MapperConfiguration(config =>
            config.AddProfile<MappingProfile>());

        _mapper = _configuration.CreateMapper();
    }

    [Test]
    public void ShouldHaveValidConfiguration()
    {
        _configuration.AssertConfigurationIsValid();
    }

    [Test]
    [TestCase(typeof(TestList), typeof(TestListDTO))]
    [TestCase(typeof(TestItem), typeof(TestItemDTO))]
    public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
    {
        var instance = GetInstanceOf(source);

        _mapper.Map(instance, source, destination);
    }

    private object GetInstanceOf(Type type)
    {
        if (type.GetConstructor(Type.EmptyTypes) != null)
            return Activator.CreateInstance(type)!;

        // Type without parameterless constructor
        return FormatterServices.GetUninitializedObject(type);
    }
}
