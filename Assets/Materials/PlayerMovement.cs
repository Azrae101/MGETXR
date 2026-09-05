using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 120f;

    void Update()
    {
        // A and D turn the capsule left/right instead of strafing sideways.
        // Since the camera is parented to the capsule, turning also turns the view.
        float turn = 0f;
        if (Keyboard.current.dKey.isPressed) turn = 1f;
        if (Keyboard.current.aKey.isPressed) turn = -1f;
        transform.Rotate(Vector3.up, turn * turnSpeed * Time.deltaTime);

        // W and S move forward/backward in whatever direction the capsule is
        // currently facing (tank controls), rather than along fixed world axes.
        float move = 0f;
        if (Keyboard.current.wKey.isPressed) move = 1f;
        if (Keyboard.current.sKey.isPressed) move = -1f;
        transform.Translate(Vector3.forward * move * speed * Time.deltaTime, Space.Self);
    }
}