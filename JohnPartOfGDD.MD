* 1.0 Basic Menus
    * 1.1: When the game is opened, the player is shown a Start Menu
        * In Unity, this is our Initial Scene in the build.
        * 1.11: The initial scene will require user interface options that let the player start the game, quit out, or other pertinent functionality
            * This can be provided for using unity Button.TMP objects. Font can be provided for via free Unity asset Thaleah Fat Font
    * 1.2: When the player hits the Escape button, a menu should open, and the game should pause. Player should then be given the option to exit back to the initial scene or continue the game
        * This can be accomplished using a disabled canvas object in unity that is re-enabled when the player hits the Escape key, and in the same function that re-enables the menu, we can set the timescale of the game to 0 'pause' the game. The buttons in this menu can be more Unity Button.TMP objects with respective functions embedded in. 
        * When the player is ready to continue, the timescale is reset to 1 and the menu is disabled again. If the player elects to quit to the initial scene instead, we can additionally load the initial scene.
    * 1.3: The player can view High Scores in the initial scene
        * This can be accomplished by loading a scene with a UI Canvas that populates with the names and scores of the High Scorers
        * 1.31: When the game ends by the player's destruction, the player will be prompted to add their name to the high score list (if applicable)
            * This can be accomplished with another unity scene, this one similar to the previous mention, but instead with an interactable text element that the player can use to add their name to their score. We can keep track of High Scores via a text file in the project assets.

* 4.0 Game Environment
    * 4.1: Visually appealilng space-themed background with scrolling
        * Can accomplish this by creating a background sprite larger than the viewing size of the camera (IE bigger than the player can see), then having the background sprite fall slowly, be replaced by spawning additional background sprites above the camera, and deleted after the sprites fall below a certain threshold on the Y-axis (when it is clearly out of view)
    * 4.2: UI elements for player health, game time, score
        * This can be accomplished by using a unity canvas to instantiate the text UI objects, then running a script in the background that checks these variables each update and changes them as necessary. For example: Game time should always be increasing, and so every update the text for the timer should be incremented by itself +1.
