using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dummy1.API.Services
{
    public interface IChat
    {
        Task<string> Greet();
        Task<string> Respond(string message);
        Task<string> ReadMessage();
        Task<IEnumerable<string>> ReadMessages();
    }
}