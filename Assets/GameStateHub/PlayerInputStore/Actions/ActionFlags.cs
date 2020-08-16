namespace PlayerInputStore
{
    namespace Actions
    {
        public class ActionFlags
        {
            // Base
            public const string ApplicationGainedFocus = "APPLICATION_GAINED_FOCUS";
            public const string ApplicationLostFocus = "APPLICATION_LOST_FOCUS";

            // Players
            public const string PlayerJoined = "PLAYER_JOINED";
            public const string PlayerLeft = "PLAYER_LEFT";
            public const string DeviceLost = "DEVICE_LOST";
            public const string DeviceRegained = "DEVICE_REGAINED";

            // Menu
            public const string MenuTraverse = "MENU_TRAVERSE";
            public const string MenuTraverseRelease = "MENU_TRAVERSE_RELEASE";
            public const string MenuConfirm = "MENU_CONFIRM";
            public const string MenuEscape = "MENU_ESCAPE";

            // PlayMenu
            public const string PlayMenuTraverse = "PLAY_MENU_TRAVERSE";
            public const string PlayMenuTraverseRelease = "PLAY_MENU_TRAVERSE_RELEASE";
            public const string PlayMenuConfirm = "PLAY_MENU_CONFIRM";
            public const string PlayMenuEscape = "PLAY_MENU_ESCAPE";
            public const string PlayMenuTransitionToGame = "PLAY_MENU_RETURN_TO_GAME";

            // Play
            public const string PlayMove = "PLAY_MOVE";
            public const string PlayMoveRelease = "PLAY_MOVE_RELEASE";
            public const string PlayCameraMove = "PLAY_CAMERA_MOVE";
            public const string PlayCameraMoveRelease = "PLAY_CAMERA_MOVE_RELEASE";
            public const string PlayPause = "PLAY_PAUSE";
            public const string PlayJump = "PLAY_JUMP";
            public const string PlayJumpRelease = "PLAY_JUMP_RELEASE";
            public const string PlayTransitionToPlayMenu = "PLAY_TRANSITION_TO_PLAY_MENU";
        }
    }
}