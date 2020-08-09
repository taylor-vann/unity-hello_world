using System;

namespace PlayerInputStore
{
    namespace Actions
    {
        public class ActionParams<T>
        {
            public readonly double playerId;
            public readonly DateTime timestamp;
            public readonly T value;

            public ActionParams(double playerId, T value)
            {
                this.playerId = playerId;
                this.timestamp = DateTime.UtcNow;
                this.value = value;
            }
        }

        public class Action<T>
        {
            public readonly string title;
            public readonly ActionParams<T> parameters;

            public Action(string title, double playerId, T value)
            {
                this.title = title;
                this.parameters = new ActionParams<T>(playerId, value);
            }
        }
    }
}