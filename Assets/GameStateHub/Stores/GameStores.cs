using UnityEngine;
using GameStateHub.GameActions;


namespace GameStateHub
{
    namespace GameStores
    {
        public class Stores
        {
            private StoresContianer storesContainer;


            public Stores()
            {
                this.storesContainer = new StoresContianer();
            }

            public void SendAction<T>(Action<T> action)
            {
                // send to all stores
                this.storesContainer.SendAction<T>(action);
            }

            public void SendActionToPlayerInputStore<T>(Action<T> action)
            {
                 this.storesContainer.playerInputStore.SendAction<T>(action);
            }

            public void GetState()
            {
                // return object that's a COPY of all states
            }
        }
    }
}

