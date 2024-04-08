* 2.0 Player Functionality
  * 2.1: A controllable player character
    * The Move() function from `PlayerController.cs` deals with managing player control mechanics. It retrieves from the normalized horizontal input vector from the gameInput object, determines the minimum and maximum x positions based on the screen edges, considering the player's width and an offset, calculates a new position for the player based on the current position, input, move speed, and delta time, ensuring it stays within the screen boundaries and updates the player's position to the calculated new position.
