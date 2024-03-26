Name: CODENAME- GalagaSurfers
Stakeholders:  
* Thavindu
* John McGuff
* Long Nguyen
* Kha Le
Overview
Concept: A hybrid 2d galaga clone and an autorunner in the same vein as some mobile games like Subway Surfers on the windows platform.
Story: TBD
Setting: TBD
Structure: The game takes place on a 2D plane with players avoiding enemies and moving forward for as long as they can until something destroys them. The game continues to increase in difficulty
by spawning more and different kinds of enemies until the game ends with the player's death. As the game continues, the player gains score based on time survived and enemies destroyed. The goal of 
the game is to simply get as high of a score as you can before you inevitably lose.

Playermovement 
|   |
      |
  |
Player moves left to right at the bottom of the screen
<--<^>-->
Player shoots automatically (a particle or object with a collider that determines hit)
Shots go in a straight line up accompanied by a sound effect

Player has MAXIMUM 5 hits  + + + + +

Enemies can come in from the top
Enemies have different spawn rates which increase as time goes on, except for the B0ss
Enemies can drop powerups

Enemies come in different varieties. Different enemy varieties have different appearances and behaviors.         

//Design ideas from Kha Le
Rock = [[[R]]]
        Hp = inf
        Floats down at varying speeds, some slowly (static), some quickly
        Gets in the way. Causes damage with a collider. 
        Non destructible.
        Moves past the screen and vanishes.
        Spawns at a regular rate

Shooter = |[s]|
            HP = 3
            Stay on top of the screen
            Moves side to side, like the player
            Shoots at the player intermittently (slower version of the player's projectile?)
            Spawn rate increases based on a factor of gametime (1 ever 10 seconds becomes 1 every 8 seconds etc)
            Shoots over rocks (they are a better shot than you)

Audio: Flying, shooting, explosion, collision, enemy noises?, warning sound for boss, menu music, game music, menu select noises

User Interface: Main menu, health indicator, timer, score, game over screen

Features if time permits...     
         
Special enemies with different behaviors... (bosses, event based enemies):
If an event like this triggers, we want to pause the usual spawning behavior of other enemies

POWER UPS (needs accompanying audio and user interface!)-

    Shield (p) = Takes ONE hit for the player
    Armor (a) = Repairs the player's hit points (Kill John Cena to get it)
    Weapon upgrades? (w+) = Modifies the player's weapon with new effects
    Power-Up ideas:
    phase drive = player moves VERY quickly for a short duration, ignoring rocks and other damage sources (turn off the colliders?) 
    (and applying a score multiplier)
