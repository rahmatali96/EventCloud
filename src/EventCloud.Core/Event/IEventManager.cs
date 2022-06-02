using System.Threading.Tasks;

namespace EventCloud.Event
{
    internal interface IEventManager
    {
        Task<object> GetRegisteredUsersAsync(object entity);
    }
}