using System.Threading.Tasks;

namespace SecretTarot.Module.Core.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}