using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target = null;
    public Vector3 offset = Vector3.zero;
    private void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
