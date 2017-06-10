using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Quidjibo.Protectors
{
    public class PayloadProtector : IPayloadProtector
    {
        public Task<byte[]> ProtectAsync(byte[] payload, CancellationToken cancellationToken)
        {
            return Task.FromResult(payload);
        }

        public Task<byte[]> UnprotectAysnc(byte[] payload, CancellationToken cancellationToken)
        {
            return Task.FromResult(payload);
        }
    }
}