using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows;

public class CharacterPhysics : MonoBehaviour
{
    public InputHandling inputHandling;
    public Rigidbody rb;
    public float thrust;

    public void jump()
    {
        rb.AddForce(transform.up * 250);
    }

    public void walk(Vector2 moveDir)
    {
        moveDir = thrust * moveDir;
        rb.AddRelativeForce(moveDir.x, 2, moveDir.y, ForceMode.Impulse);
    }

}
