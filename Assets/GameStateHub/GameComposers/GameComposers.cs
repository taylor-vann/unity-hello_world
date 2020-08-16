using System;
using GameStateHub.GameActions;

namespace GameStateHub
{
    namespace GameComposers
    {
        public class ComposerState<T>
        {
            private T DefaultComposerState;
            private T CurrentComposerState;

            public ComposerState(T defaultState)
            {
                this.DefaultComposerState = defaultState;
                this.CurrentComposerState = this.DefaultComposerState;
            }

            public void ReadAction(Action action) { }
            public T GetCopyOfState() { return this.CurrentComposerState; }

        }
        public class Composer<T>
        {
            private ComposerState<T> defaultComposerState;

            public void ReadAction(Action action)
            {
                defaultComposerState.ReadAction(action);
            }
            public T GetState()
            {
                return defaultComposerState.GetCopyOfState();
            }
        }
    }
}
