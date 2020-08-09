# Hello World

Somewhere to start in Unity.

## Progress

Multiplayer input through PlayerInputManager. Its a singleton. So we can use it as a way to implement a store. PlayerInputManager creates PlayerInputs. We use PlayerInput to reference back to PlayerInputManager.


```
PlayerInputManager <--> PlayerInput
              ^          /
               \        /
                --------
```

From here we can create a store accessible game objects or an ECS. Its a single source of truth pattern without creating our own singletons. 
