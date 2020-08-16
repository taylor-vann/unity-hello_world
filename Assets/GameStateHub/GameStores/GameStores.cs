using UnityEngine;
using GameStateHub.GameActions;


namespace GameStateHub
{
    namespace GameStores
    {

        public class Stores
        {
            private StoreContianer storeContainer;

            public Stores()
            {
                this.storeContainer = new StoreContianer();
            }

            public void SendAction<T>(Action<T> action)
            {
                // send to all stores
                Debug.Log(action.flag);
                this.storeContainer.SendAction<T>(action);
            }

            public void SendActionToPlayerInputStore<T>(Action<T> action)
            {
                Debug.Log(action.flag);
                this.storeContainer.playerInputStore.SendAction<T>(action);
            }

            public void GetState()
            {
                // return object that's a COPY of all states
            }
        }
    }
}

