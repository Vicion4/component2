using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public PlayerController CharacterController;
    private InputAction _moveAction, _lookAction, _jumpAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        _lookAction = InputSystem.actions.FindAction("Look");

        Cursor.visible = false;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector2 lookVector = _lookAction.ReadValue<Vector2>();
        CharacterController.Rotate(lookVector);
    }

    
    
    
}
