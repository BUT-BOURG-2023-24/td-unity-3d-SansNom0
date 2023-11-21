using UnityEngine;
using UnityEngine.InputSystem;
public class SpawnCubeOnMouseClick : MonoBehaviour
{
    public InputActionReference clickActionRef = null;
    public LayerMask groundLayer;
    public GameObject toSpawnObject = null;
    public float spawnHeightOffset = 1.0f;

    private void OnEnable()
    {
        clickActionRef.action.performed += OnMouseClicked;
    }
    private void OnDisable()
    {
        clickActionRef.action.performed -= OnMouseClicked;
    }

    private void OnMouseClicked(InputAction.CallbackContext context)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction, Color.blue, 100.0f);
        Debug.Log("Mouse position: " + Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, 1000f, groundLayer)) {
            Vector3 spawnPoint = hitInfo.point;
            spawnPoint.y += spawnHeightOffset;
            GameObject.Instantiate(toSpawnObject, spawnPoint, Quaternion.identity);
        }
    }
}