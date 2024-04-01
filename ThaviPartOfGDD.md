* 2.0 Player Functionality
    * 2.1: Controllable Player Character
        * Player character is controllable using keyboard controls
        * This is implemented using the Unity Legacy input system which captures keyboard inputs
    * 2.2: Moves left and right with keyboard controls
        * Using ← and → keyboard buttons on the keyboard, player can move left and right on the screen
    * 2.3: Player character fires a projectile
        * 2.31: Projectile is fired upon pressing a key
            * Upon pressing the `<SPACEBAR>` key once, the player spaceship fires a projectile
    * 2.4: Powerups that alter fired projectile/player stats
        * Powerups will spawn from the top of the screen
        * Player has to catch them in order to equip
        * Two Types of Powerups
            * Projectile Powerup: Upgrades to firing two projectiles at once
            * Shield: 
                * A temporary shield provides protection from enemy attacks
                * The shield lasts 10 seconds before depleteion or if it gets hit before that
        * Powerup Drop Frequency:
            * If the Projectile Powerup is already equipped, it will not spawn again
            * The Shield Powerup will keep spawning after it has been depleted
    * 2.5: Player character can be damaged after getting hit once by an enemy
        * 2.51: Player character is briefly invincible after being hit (indicated by blinking model)
            * The player spaceship blinks three times after getting hit by an enemy attack
        * 2.52: Player has three hearts
            * The hearts are indicated on the top left of the screen
            * Each time a player gets attacked by an enemy, one heart is lost
        * 2.53: Player regenerates where they were attacked as long as there are lives
            * Player can progress from where they lost
        * 2.54: Player has to restart when all lives are lost (game over)
            * Progress from the beginning


