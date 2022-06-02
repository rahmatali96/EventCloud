namespace EventCloud.Event
{
    internal class EventCancelledEvent
    {
        private Event @event;

        public EventCancelledEvent(Event @event)
        {
            this.@event = @event;
        }
    }
}