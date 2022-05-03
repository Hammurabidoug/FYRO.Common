using FYRO.Domain;

namespace FYRO.Application.Abstractions;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
