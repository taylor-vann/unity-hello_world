using UnityEngine;
using PlayerInputStore.Actions;

namespace PlayerInputStore
{

    // dispatch actions
    public class Store
    {
        // responsibilities:
        //   - set default state of player controllers
        //   - represent current state of player controllers
        //   - lock / release action input (a 'mutex' of sorts)
        //   - set playerInput action maps (unified input for all players)
        //   - provide a stateful, serializable object for our ECS to consume
        // 
        // we do this through actions!
        //
        // sendAction();
        // getStoreState();

        public void SendAction<T>(Action<T> action)
        {
            Debug.Log(action.title);
        }
    }
}