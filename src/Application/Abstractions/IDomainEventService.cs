using FYRO.Common.Domain;

namespace FYRO.Common.Application.Abstractions;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
