namespace EventCloud.Event
{
    internal class EventDateChangedEvent
    {
        private Event @event;

        public EventDateChangedEvent(Event @event)
        {
            this.@event = @event;
        }

        public object Entity { get; internal set; }
    }
}