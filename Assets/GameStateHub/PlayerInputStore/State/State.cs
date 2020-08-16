namespace PlayerInputStore
{
    // bunch of composers

    // devicesComposer
    // --> references to controller abstractions
    // --> not able to reference, not serializable

    // playerActionComposer
    // --? most recent action?
    // --> references to controller state

    // GetState() -> returns COPY of state (important)



    // list of PlayerInputs

    // store {
    //   playerId {
    //     actionMap
    //     dpad_north
    //     two_axis
    //     axis_right_stick
    //     button_west
    //     button_north
    //   }
    //   ...
    // }

    namespace State
    {

    }
}