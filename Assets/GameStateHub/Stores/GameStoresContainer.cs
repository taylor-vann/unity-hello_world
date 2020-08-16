using UnityEngine;

using GameStateHub.GameActions;

using PStore = GameStateHub.PlayerInputStore.Store;


namespace GameStateHub
{
    namespace GameStores
    {
        public class StoresContianer
        {
            public readonly PStore playerInputStore = new PStore();

            public void SendAction<T>(Action<T> action)
            {
                // send to all stores
                this.playerInputStore.SendAction<T>(action);
            }

            public void SendActionToPlayerInputStore<T>(Action<T> action)
            {
                this.playerInputStore.SendAction<T>(action);
            }
        }
    }
}

