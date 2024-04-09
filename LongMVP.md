## 3.0 Enemy Functionality

### 3.1: Come in different varieties

- There are two types of enemies:
  1. Asteroid (Figure 1)
  2. Enemy ship (Figure 2)

#### Figure 1 and Figure 2:
![enemy](https://github.com/WinterBlue-CEG4110/Team-Project/assets/97487237/5b8b0ea4-6c62-4fb5-97f6-19db2b21a9f6)  ![enemyShip](https://github.com/WinterBlue-CEG4110/Team-Project/assets/97487237/d53c30a5-022d-4964-b65c-59e7f7c48043)



##### 3.11: Enemies have different attacks and behaviors

- 3.12: Enemies look different depending on enemy type

a.) **Asteroid:**
   - Moves only downwards vertically and respawns at different places; its movement should increase. The code in Figure 3 will handle all the functionality of the Asteroid.
     * The enemy's speed increases over time in regular intervals.
     * The interval for speed increment is set to 3 seconds.
     * The amount of speed increased per interval is set to 0.5 units.
     * The script moves the enemy downwards continuously in the Update() method.
     * It increases the enemy's speed by the defined increment value at regular intervals.
     * The Respawn() method is responsible for generating a random respawn position for the enemy within the defined boundaries, placing it above the top boundary by 2 units.

#### Figure 3:
![figure3](https://github.com/WinterBlue-CEG4110/Team-Project/assets/97487237/a6a1181a-6a4a-44bb-adc3-f9af8230c012)


b.) **Enemy Ship:**
   - Moves down vertically and respawns at different places but stops at a certain position on the y-axis. It should be able to shoot projectiles, and when it respawns, the enemy movement remains the same. The code in Figure 4 and Figure 5 will handle all the functionality of the enemy ship.
     - Figure 4 functionally:
       * The script controls shooting behavior for a GameObject. It allows access to the prefab of the projectile.
       * It defines a shoot interval, allowing adjustment of the time between shots.
       * It tracks the time of the last shot.
       * Upon starting, it initializes the time of the last shot.
       * In the Update() method, it checks if enough time has passed since the last shot.
       * If the specified interval has elapsed, it instantiates a projectile at the GameObject's position.
       * After shooting, it updates the time of the last shot.
     - Figure 5 functionally:
       * It stores the original position of the enemy.
       * Defines boundaries for the enemy's movement (left, right, and top boundaries).
       * Specifies the "y" position where the enemy should stop descending.
       * Tracks whether the enemy is currently respawning.
       * Allows adjustment of the respawn time in seconds.
       * Upon starting, it stores the original position of the enemy.
       * In the Update() method, it moves the enemy downwards only if it hasn't reached the specified stop position and is not currently respawning.
       * Provides a Respawn() method to handle enemy respawning.
       * Within Respawn(), it sets the respawning flag, generates a random respawn position within the defined boundaries, moves the enemy to the new position, and starts a coroutine to reset the respawning flag after the specified respawn time.
       * Uses a coroutine, ResetRespawnFlag(), to reset the respawning flag after a certain duration.

#### Figure 4 and Figure 5:
![figure 4](https://github.com/WinterBlue-CEG4110/Team-Project/assets/97487237/fd6a2fd3-9aaa-473c-8496-2ddb0e4c0971) ![figure5](https://github.com/WinterBlue-CEG4110/Team-Project/assets/97487237/ca737243-aca6-46b8-9151-ea96025a3af2)



### 3.2: Enemies have different amounts of hitpoints that are depleted when hit by an enemy
   - Due to time constraints, I haven't begun this yet.

### 3.3: Enemies are worth different amounts of score when destroyed
   - Due to time constraints, I haven't begun this yet.

### 3.4: Enemies become more difficult has time progresses in the game
   - a.) The only enemy that will become more difficult as time passes is the asteroid. The code in Figure 3 will handle the speed functionality of the Asteroid.
