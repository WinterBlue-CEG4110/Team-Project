using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base Projtile script to make it fall
/// Written By Thavi
/// </summary>
public class Projectile : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.up);        
    }

}
