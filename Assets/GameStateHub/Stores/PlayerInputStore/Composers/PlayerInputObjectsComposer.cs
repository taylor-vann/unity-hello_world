using System.Collections.Generic;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;

using GameStateHub.GameActions;
using GameStateHub.GameComposers;

using PlayerInputStore.States;


namespace PlayerInputStore
{
    // classes that take in an action and return a new object for statefullness
    namespace Composers
    {
        // classes that take in an action and return a new object for statefullness
        public class PlayerInputObjectsComposer : Composer<PlayerInputObjectsState>
        {
            public override void ReadAction<U>(Action<U> action)
            {

            }

            public override PlayerInputObjectsState GetState()
            {

            }
        }
    }
}