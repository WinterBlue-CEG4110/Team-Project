using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages Player Controller Mechanics
/// Written By Thavi
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField] [Range(0f,10f)] private float moveSpeed;

    [SerializeField] private Renderer Renderer;
    [SerializeField] private GameInput gameInput;
    public PlayerShootingManager shootingManager;
    public Health health;

    private float offset = 0.5f;

    void Update()
    {
        Move();
    }
    private void Move()
    {
        // Get the normilized input from game input.
        Vector2 inputVectorNormalized = gameInput.GetInputVectorNormalized();
        Vector3 moveDir = new Vector3(inputVectorNormalized.x, 0f, 0f);

        // Calculate the minimum and maximum x positions based on screen edges
        float objectWidth = Renderer.bounds.size.x + offset;
        float minX = Camera.main.ViewportToWorldPoint(Vector3.zero).x + objectWidth / 2; // Left edge
        float maxX = Camera.main.ViewportToWorldPoint(Vector3.one).x - objectWidth / 2; // Right edge

        // Update the position while clamping the x value
        Vector3 newPosition = transform.position + moveDir * Time.deltaTime * moveSpeed;
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        transform.position = newPosition;

        //transform.position += moveDir * Time.deltaTime * moveSpeed;
    }
}
