using UnityEngine;

using GameStateHub.GameActions;

using PStore = GameStateHub.PlayerInputStore.Store;


namespace GameStateHub
{
    namespace GameStores
    {
        public class StoreContianer
        {
            public readonly PStore playerInputStore = new PStore();

            public void SendAction<T>(Action<T> action)
            {
                // send to all stores
                Debug.Log(action.flag);
                this.playerInputStore.SendAction<T>(action);
            }

            public void SendActionToPlayerInputStore<T>(Action<T> action)
            {
                Debug.Log(action.flag);
                this.playerInputStore.SendAction<T>(action);
            }
        }
    }
}

