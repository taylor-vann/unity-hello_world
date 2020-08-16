using UnityEngine;
using GameStateHub.GameActions;

using PStore = PlayerInputStore.Store;

namespace GameStateHub
{
    namespace GameStores
    {
        public class StoreContianer
        {
            public readonly PStore playerInputStore = new PStore();
        }

        public class Stores
        {
            private StoreContianer stores;

            public Stores()
            {
                this.stores = new StoreContianer();
            }

            public void SendAction<T>(Action<T> action)
            {
                // send to all stores
                Debug.Log(action.flag);
                this.stores.playerInputStore.SendAction<T>(action);
            }

            public void SendActionToPlayerInputStore<T>(Action<T> action)
            {
                Debug.Log(action.flag);
                this.stores.playerInputStore.SendAction<T>(action);
            }
        }
    }
}

