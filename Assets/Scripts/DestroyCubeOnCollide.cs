using UnityEngine;

public class DestroyCubeOnCollide : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Cube")) {
            Destroy(collision.gameObject);
        }
    }
}
