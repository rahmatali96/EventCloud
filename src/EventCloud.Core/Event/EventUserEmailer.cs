

using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.Events.Bus.Entities;
using Abp.Events.Bus.Handlers;
using Abp.Threading;
using Castle.Core.Logging;
using EventCloud.Authorization.Users;
using System.Linq;

namespace EventCloud.Event
{
    public class EventUserEmailer :
        IEventHandler<EntityCreatedEventData<Event>>,
        ITransientDependency
    {
        public ILogger Logger { get; set; }

        private readonly IEventManager _eventManager;
        private readonly UserManager _userManager;



        [UnitOfWork]
        public virtual void HandleEvent(EntityCreatedEventData<Event> eventData)
        {
            //TODO: Send email to all tenant users as a notification

            var users = _userManager
                .Users
                .Where(u => u.TenantId == eventData.Entity.TenantId)
                .ToList();

            foreach (var user in users)
            {
                var message = string.Format("Hey! There is a new event '{0}' on {1}! Want to register?", eventData.Entity.Title, eventData.Entity.Date);
                Logger.Debug(string.Format("TODO: Send email to {0} -> {1}", user.EmailAddress, message));
            }
        }

       
    }
}
