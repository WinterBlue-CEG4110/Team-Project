using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages Gmae Inputs
/// Written By Thavi
/// </summary>
public class GameInput : MonoBehaviour
{
    [SerializeField] private PlayerShootingManager shootingManager;

    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        // Init player input manually
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();

        // linking shooting action
        playerInputActions.Player.shoot.performed += _ => shootingManager.Shoot();
        
    }

    public Vector2 GetInputVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }

    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    private void OnDisable()
    {
        playerInputActions.Disable();
    }
}
