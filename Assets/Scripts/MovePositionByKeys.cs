using UnityEngine;

public class MovePositionByKeys : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool upArrow = Input.GetKey(KeyCode.UpArrow);
        bool downArrow = Input.GetKey(KeyCode.DownArrow);
        bool rightArrow = Input.GetKey(KeyCode.RightArrow);
        bool leftArrow = Input.GetKey(KeyCode.LeftArrow);
        Vector3 inputPos = Vector3.zero;
        if (upArrow) {
            inputPos.z = 1f;
        }
        if (downArrow) {
            inputPos.z = -1f;
        }
        if (rightArrow) {
            inputPos.x = 1f;
        }
        if (leftArrow) {
            inputPos.x = -1f;
        }
        transform.position += inputPos * Time.deltaTime * speed;
    }
}
