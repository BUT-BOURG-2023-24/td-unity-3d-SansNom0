using UnityEngine;
using UnityEngine.InputSystem;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;
public class SpawnCubeOnMouseClick : MonoBehaviour
{
    public InputActionReference clickActionRef = null;
    public LayerMask groundLayer;
    public GameObject toSpawnObject = null;
    public Joystick joystick = null;
    public float spawnHeightOffset = 1.0f;

    private void OnEnable()
    {
        clickActionRef.action.performed += OnMouseClicked;
        EnhancedTouch.TouchSimulation.Enable();
        EnhancedTouch.EnhancedTouchSupport.Enable();
        EnhancedTouch.Touch.onFingerDown += OnFingerDown;
    }
    private void OnDisable()
    {
        clickActionRef.action.performed -= OnMouseClicked;
        EnhancedTouch.Touch.onFingerDown -= OnFingerDown;
        EnhancedTouch.TouchSimulation.Disable();
        EnhancedTouch.EnhancedTouchSupport.Disable();
    }

    private void OnMouseClicked(InputAction.CallbackContext context)
    {
        SpawnCube(Input.mousePosition);
    }

    private void OnFingerDown(EnhancedTouch.Finger finger)
    {
        RectTransform joystickRect = (joystick.transform as RectTransform);
        Vector2 posMin = joystickRect.offsetMin;
        Vector2 posMax = joystickRect.offsetMax;
        if (finger.screenPosition.x > posMin.x && finger.screenPosition.y > posMin.y && finger.screenPosition.x < posMax.x && finger.screenPosition.y < posMax.y) {
            SpawnCube(finger.screenPosition);
        }
    }

    private void SpawnCube(Vector2 screenPosition)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        Debug.Log("Mouse position: " + screenPosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, 1000f, groundLayer)) {
            Vector3 spawnPoint = hitInfo.point;
            spawnPoint.y += spawnHeightOffset;
            GameObject.Instantiate(toSpawnObject, spawnPoint, Quaternion.identity);
        }
    }
}