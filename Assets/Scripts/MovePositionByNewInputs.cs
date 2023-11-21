using UnityEngine;
using UnityEngine.InputSystem;

public class MovePositionByNewInputs : MonoBehaviour
{
    public float speed = 10.0f;
    public InputActionReference moveInputRef = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputMovement = moveInputRef.action.ReadValue<Vector2>();
        transform.position += new Vector3(
            inputMovement.x * speed * Time.deltaTime,
            0.0f,
            inputMovement.y * speed * Time.deltaTime
        );
    }
}
