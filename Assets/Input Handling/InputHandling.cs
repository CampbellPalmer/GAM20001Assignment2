using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputHandling : MonoBehaviour
{
    public CharacterPhysics characterPhysics;

    InputAction jumpAction;
    InputAction walkAction;

    public void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
        walkAction = InputSystem.actions.FindAction("Move");
    }
    void Update()
    {
        if (jumpAction.WasPressedThisFrame())
        {
            Debug.Log("Jump");
            characterPhysics.jump();
        }

        if (walkAction.WasPressedThisFrame())
        {
            Debug.Log(walkAction.ReadValue<Vector2>());
            characterPhysics.walk(walkAction.ReadValue<Vector2>());
        }
    }

}