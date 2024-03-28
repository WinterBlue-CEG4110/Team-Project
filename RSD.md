# Requirement Specification Document

## Introduction
* Overview: The project aims to develop a classic hybrid 2d galaga clone/autorunner.
* Purpose and Goals: Create an entertaining and challenging game with intuitive controls, captivating visuals, and responsive gameplay.
* Target Audience: Generally everyone, fans of retro games? Astronauts?
* Platform(s): Windows Desktop
## Scope
* Included Features:
  * Keyboard controls.
  * Multiple enemy types with varying movement patterns.
  * Power-ups, such as rapid fire and shields.
  * Increasing difficulty levels and challenging boss fights.
* Exclusions:
  * Multiplayer functionality.
  * In-app purchases for additional lives or power-ups.
## Functional Requirements
* 1.0 Basic Menus
  * 1.1: When the game is opened, the player is shown a Start Menu
    * 1.11: Can hit 'Start/Play' to begin the game
  * 1.2: The player can open a pause menu at any time
    * 1.21: The pause menu can be used to exit the game or continue at a time of the player's choosing
  * 1.3: The player can view the High Scores by pressing a button here
    * 1.31: When the game ends, the player will be prompted to add a name to save their score to the high score list
* 2.0 Player Functionality
  * 2.1: A controllable player character
  * 2.2: Moves left and right with keyboard controls
  * 2.3: Player character fires a projectile
    * 2.31: Projectile is fired upon pressing a key
  * 2.4: Powerups that alter fired projectile/player stats
  * 2.5: Player character can be damaged after getting hit once by an enemy
    * 2.51: Player character is briefly invincible after being hit (indicated by blinking model)
    * 2.52: Player has three hitpoints/lives/hearts
    * 2.53: Player regenerates where they were attacked as long as there are lives)
    * 2.54: Player has to restart when all lives are lost (game over)     
* 3.0 Enemy Functionality
  * 3.1: Come in different varieties
    * 3.11: Enemies have different attacks and behaviors
    * 3.12: Enemies look different depending on enemy type
  * 3.2: Enemies have different amount of hitpoints that are depleted when hit by an enemy
  * 3.3: Enemies are worth different amounts of score when destroyed
  * 3.4: Enemies become more difficult has time progresses in the game
* 4.0 Game Environment
  * 4.1: Visually appealing space-themed background with scrolling.
  * 4.2: UI elements for player health, game time, score
* 5.0 Audio
  * 5.1: Sounds for gameplay (player/enemy projectile noises)
  * 5.2: Background music
  * 5.3: Menu sounds

