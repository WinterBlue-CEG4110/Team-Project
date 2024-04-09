* 5.0 Audio
  * 5.1: Sounds for gameplay
    * A variety of sound effects for different gameplay actions, e.g.:
        * Shooting, Explosions and destruction, Items pick-up...
        * Audio clips are stored in Audio Folder in Asset
        * ![1](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/a91508f7-6bc0-48c5-ba7f-3f43fbc06509)
        
        * and is controlled by a game object called Audio Manager
        * ![2](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/df221f71-7a2d-4bcb-8c81-49ae42261954)
        * ![3](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/11996675-6b8c-4daf-a823-17a5d537de8e)
  * 5.2: Background music
    * For in-game music
    * ![4](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/d08cc298-a434-46e6-b0a1-0388e85810e0)
    * ![5](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/2c0f9e15-07a4-42b5-9317-f740d79c86e6)

    * Music loops seamlessly
    * ![7](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/cc519987-db9c-4a8e-ae0c-d8b4c9f3d86f)

  * 5.3: Menu sounds
    * A menu music that is different from gameplay background music
    * ![8](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/549f2a77-aa2f-4118-9aff-72043b901a43)
    * ![6](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/7b32f898-6fe1-4d66-adf8-b4434e16b633)

    * Menu music also loops
    * ![7](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/93ec89ed-55e9-49e7-ba74-02465ec132b0)

    * Sound effects for button clicks by calling this function
    * ![9](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/f8101b2f-b15c-4eaf-bf67-1679b479f09a)
    * Fuction is called when onClick event is triggered
    * ![10](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/8d0eccb1-c91d-4e7d-b6f6-6e9cd65b1e9b)

  * 5.4: Music and sound is adjustable 
    * Implement audio settings in the options menu for music using audio mixer.
    * ![13](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/20ccc29e-ada6-4170-aba7-1e72ee2786df)
    
    * Provide sliders UI elements for controlling audio volume levels.
        * In main menu
        * ![11](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/209f191c-cc52-4171-8c17-6ee9aa4de2a2)
     
        * In-game pause menu
        * ![12](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/660b931d-9b23-42ec-b54e-951c6e9bb16f)

    * Then use script to connect value of slider to control the mixer's parameter
    * ![14](https://github.com/WinterBlue-CEG4110/Team-Project/assets/70625271/95bf6e69-6664-4efc-8777-686e85267e7e)
