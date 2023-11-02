using UnityEngine;
using UnityEngine.InputSystem;

public class UserInput : MonoBehaviour
{
    public void Press(InputAction.CallbackContext callbackContext)
    {
        Debug.Log(callbackContext);
    }

    public void PressPosition(InputAction.CallbackContext callbackContext)
    {
        Debug.Log(callbackContext.ReadValue<Vector2>());
    }
}
