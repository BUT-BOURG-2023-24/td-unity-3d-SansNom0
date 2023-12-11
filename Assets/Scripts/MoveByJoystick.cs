using UnityEngine;

public class MoveByJoystick : MonoBehaviour
{
    public Joystick joystick = null;
    public float speed = 10.0f;
    public Rigidbody body = null;

    void Update()
    {
        Vector2 inputMove = joystick.Direction;
        body.velocity = new Vector3(
            inputMove.x * speed,
            body.velocity.y,
            inputMove.y * speed
        );
    }
}
