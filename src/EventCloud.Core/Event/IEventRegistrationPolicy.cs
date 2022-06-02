using EventCloud.Authorization.Users;
using System.Threading.Tasks;

namespace EventCloud.Event
{
    public interface IEventRegistrationPolicy
    {
        Task CheckRegistrationAttemptAsync(Event @event, User user);
    }
}