using System;

namespace GameActions
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
        public readonly string flag;
        public readonly ActionParams<T> parameters;

        public Action(string flag, double playerId, T value)
        {
            this.flag = flag;
            this.parameters = new ActionParams<T>(playerId, value);
        }
    }
}
