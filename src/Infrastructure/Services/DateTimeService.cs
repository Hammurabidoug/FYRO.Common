using FYRO.Common.Application.Abstractions;

namespace FYRO.Common.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
