using rfidMid.core.Domain.Entities;
using rfidMid.core.Domain.Interfaces;
using System.Net.Http.Headers;


namespace rfidMid.infrastructure.simulator
{
    public class Simulator
    {
        private readonly Random random = new();
        private readonly String[] sampleTags = { "tag123", "tag456", "tag789", "tag124", "tag123", "tag789" };

        public event EventHandler<Tag>? tagRead;

    public async Task StartAsync(CancellationToken cancellationToken) 
        {
            while (!cancellationToken.IsCancellationRequested) {

            string id = sampleTags[random.Next(sampleTags.Length)];

                var tag = new Tag { Id = id,Timestamp = DateTime.Now };

                tagRead?.Invoke(this,tag);

                await Task.Delay(1000, cancellationToken);
            }
        }
    }
}
