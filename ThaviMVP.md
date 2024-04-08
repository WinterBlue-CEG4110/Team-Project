* 2.0 Player Functionality
  * 2.1: A controllable player character
    * `Move()` function from `PlayerController.cs` deals with managing player control mechanics. It does the following steps:
       1. Retrieves the normalized horizontal input vector from the gameInput object
       2. Creates a movement direction vector in 3D space, considering only horizontal movement
       3. Determines the minimum and maximum x positions based on the screen edges, considering the player's width and an offset
       4. Calculates a new position for the player based on the current position, input, move speed, and delta time, ensuring it stays within the screen boundaries
       5.  Updates the player's position to the calculated new position
       ![Move()](./MVP-media/2.1.png)

  * 2.2: Moves left and right with keyboard controls
    * In `@PlayerInputActions()` of `PlayerInputActions.cs`, `<Keyboard>` Left and Right refer to the specific keys on the keyboard that are mapped to the player's left and right movement, respectively. Input from these keys triggers the player object to go left or right using left or right arrow keys
      ![LeftAndRight](./MVP-media/2.2.png)

  * 2.3: Player character fires a projectile
    * `Projectile` Class of `Projectile.cs` makes the projectile move vertically upwards at a constant speed defined by `moveSpeed`. It implements a projectile that falls or moves upward in the game world.
      ![Projectile](./MVP-media/2.3.png)
      * 2.31: Projectile is fired upon pressing a key
        * In `@PlayerInputActions()` of `PlayerInputActions.cs`, "shoot" is the action that fires a projectile. This action has a binding (Unnamed: """") which makes the action "shoot" trigger by pressing the spacebar on the `<Keyboard>`
        ![shoot](./MVP-media/2.3.1.png)

  * 2.4: Powerups that alter fired projectile/player stats
    * Shield Powerup: `PowerUpShield` class of `PowerUpShield.cs` represents a specific type of power-up that, upon collision with the player character, activates a shield to provide protection
     ![shield](./MVP-media/2.4.1.png)
    * Projectile Upgrade Powerup: `PowerUpProjectileUpgrade` class of `PowerUpProjectileUpgrade.cs` represents a specific type of power-up that, upon collision with the player character, upgrades the projectile fired by the player to two projectiles at once
     ![doubleGun](./MVP-media/2.4.2.png)

  * 2.5: Player character can be damaged after getting hit once by an enemy
    * 2.51: Player character is briefly invincible after being hit (indicated by blinking model)
      * In `Health.cs`, `BecomeInvincible()` coroutine sets the `isInvincible` flag to true, indicating that the player is currently in an invincible state. It then starts another coroutine called `StartBlinking()` to make the player model blink. `BlinkModel()` coroutine continuously toggles the visibility of the player model's renderer component while the `isInvincible` flag is true. It toggles the visibility by setting `modelRenderer.enabled` to the opposite of its current value.
      ![blinkmodel](./MVP-media/2.5.1.png)
   * 2.52: Player has three hitpoints/lives/hearts
     * In `Health` class of `Health.cs`, `Start()` initializes the health variables and sets the `currentHealth` to `maxHealth` so that at the start of the game, the player will have three hearts.
     ![hearts](./MVP-media/2.5.2.png)  
