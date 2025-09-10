using rfidMid.core.Domain.Entities;

namespace rfidMid.core.Domain.Interfaces
{
    public interface ITagReader
    {
        event EventHandler<Tag> TagRead;
        Task<Tag> StartAsync(CancellationToken cancellationToken);


    }
}
