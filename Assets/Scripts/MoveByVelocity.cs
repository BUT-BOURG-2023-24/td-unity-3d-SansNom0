using UnityEngine;
using UnityEngine.InputSystem;

public class MoveByVelocity : MonoBehaviour
{
    public Rigidbody body = null;
    public InputActionReference moveInputRef = null;
    public float speed = 100.0f;
    void Update()
    {
        Vector2 inputMouvement = moveInputRef.action.ReadValue<Vector2>();
        body.velocity = new Vector3(inputMouvement.x * speed, body.velocity.y, inputMouvement.y * speed);
    }
}