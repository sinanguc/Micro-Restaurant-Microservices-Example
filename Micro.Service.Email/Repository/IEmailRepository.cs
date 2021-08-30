using Micro.Service.Email.Messages;
using System.Threading.Tasks;

namespace Micro.Service.Email.Repository
{
    public interface IEmailRepository
    {
        Task SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
