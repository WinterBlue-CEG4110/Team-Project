* 1.0 Basic Menus
    * 1.1: When the game is opened, the player is shown a Start Menu
        * In Unity, this is our Initial Scene in the build.
        * 1.11: The initial scene has user interface options that let the player start the game, quit out, view options, and view credits.
            * This can be provided for using unity Button.TMP objects. Font can be provided for via free Unity asset Thaleah Fat Font
            ![alt text](./MVP-mediaStart.png)
            ![alt text](./MVP-mediaStartMenuScript.png)
    * 1.2: When the player hits the Escape button, a menu opens, and the game pauses.
    ![alt text](./MVP-mediaPauseUI.png)
        * This is accomplished by using a disabled canvas object in unity that is re-enabled when the player hits the Escape key,
        ![alt text](./MVP-mediaHiddenUI.png)
        ...and in the same function that re-enables the menu, we can set the timescale of the game to 0 'pause' the game. The buttons in this menu are more Unity Button.TMP objects with respective functions embedded in. 
        ![alt text](./MVP-mediaPause.png)
        ![alt text](./MVP-mediaPauseMenuButtons.png)
        * When the player is ready to continue, the timescale is reset to 1 and the menu is disabled again. If the player elects to quit to the initial scene instead, we can additionally load the initial scene.
        ![alt text](./MVP-mediaResume.png)
        ![alt text](./MVP-mediaQuit.png)
    * 1.3: The player can view High Scores in the initial scene
        * This is accomplished by loading a scene with a UI Canvas that populates with the names and scores of the High Scorers. 
        ![alt text](./MVP-mediaScoreboardBase.png)
        ![alt text](./MVP-mediaScoreboardPopulateScript.png)
        * We keep track the scores by saving/loading from a .json file, letting users save their
        accomplishments even when the game has exited.
        * 1.31: When the game ends by the player's destruction, the player will be prompted to add their name to the high score list
            * This is accomplished with another hidden UI object that has a textfield that can be read in as the name that goes along the player's score, which can be potentially added to the .json.
            ![alt text](./MVP-mediaHiddenGameOverUI.png)
            ![alt text](./MVP-mediaGameOverUI.png)
            * We then load the scoreboard scene, where the player gets to see if they've gained a new high score!
            ![alt text](./MVP-mediaScoreboard.png)

* 4.0 Game Environment
    * 4.1: Visually appealilng space-themed background with scrolling
        * We accomplish this by creating a background sprite larger than the viewing size of the camera (IE bigger than the player can see),  
        ![alt text](./MVP-mediaBackground.png)
        ...then having the background sprite fall slowly and be deleted after the sprites fall below a certain threshold on the Y-axis (when it is clearly out of view),
        ![alt text](./MVP-mediaBackgroundMotion.png)
        ...then be replaced by spawning additional background sprites above the camera. 
        ![alt text](./MVP-mediaSkyspawner.png)
    * 4.2: UI elements for player health, game time, score
        * This was accomplished by using a unity canvas to instantiate the text UI objects, 
        ![alt text](./MVP-mediaMainSceneUI.png)
         ...then running a script in the background that checks these variables each update and changes them as necessary.