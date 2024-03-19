using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputHandling : MonoBehaviour
{
    InputAction jumpAction;
    InputAction walkAction;
    private void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
        walkAction = InputSystem.actions.FindAction("Move");
    }
    void Update()
    {
        if (jumpAction.WasPressedThisFrame())
        {
            Debug.Log("Jump");
        }
        
        if (walkAction.WasPressedThisFrame())
        {
            Debug.Log(walkAction.ReadValue<Vector2>());
        }
    }

    
}
