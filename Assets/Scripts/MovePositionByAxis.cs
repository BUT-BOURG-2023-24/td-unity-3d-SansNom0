using UnityEngine;

public class MovePositionByAxis : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        Debug.Log("X Axis: " + xAxis);
        Debug.Log("Y Axis: " + yAxis);
        transform.position += new Vector3(xAxis * speed * Time.deltaTime, 0, yAxis * speed * Time.deltaTime);
    }
}
