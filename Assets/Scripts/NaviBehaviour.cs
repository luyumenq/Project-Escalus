using UnityEngine;
using UnityEngine.InputSystem;

public class NaviBehaviour : MonoBehaviour
{
    InputAction moveAction;
    InputAction jumpAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveValue = moveAction.ReadValue<Vector3>();
        // movement code here
        

        if (jumpAction.IsPressed()) {
            // jump action here
        }
    }
}
