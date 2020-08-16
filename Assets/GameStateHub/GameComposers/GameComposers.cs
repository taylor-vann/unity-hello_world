using GameStateHub.GameActions;

namespace GameStateHub
{
    namespace GameComposers
    {
        public abstract class ComposerState<T>
        {
            public abstract void ReadAction<U>(Action<U> action);
            public abstract T GetCopyOfState();
        }

        public abstract class Composer<T>
        {
            public abstract void ReadAction<U>(Action<U> action);
            public abstract T GetState();
        }
    }
}
