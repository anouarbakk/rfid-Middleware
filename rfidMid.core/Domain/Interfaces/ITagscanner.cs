using rfidMid.core.Domain.Entities;

namespace rfidMid.core.Domain.Interfaces
{
    public interface ITagscanner
    {
        event EventHandler<Tag> TagScan;
        Task<Tag> StartAsync(CancellationToken cancellationToken);
    }
}
