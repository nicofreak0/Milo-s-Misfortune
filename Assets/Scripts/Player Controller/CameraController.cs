using UnityEngine;

public class CameraController : MonoBehaviour
{
    private InputManager inputManager;
    private Vector3 startingRotation;
    public float clampAngle = 80f;
    public float horizontalSpeed = 10f;
    public float verticalSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputManager = InputManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 deltaInput = inputManager.GetMouseDelta();
        startingRotation.x += deltaInput.x * Time.deltaTime;
        startingRotation.y += deltaInput.y * Time.deltaTime;
        startingRotation.y = Mathf.Clamp(startingRotation.y, -clampAngle, clampAngle);
        //state.RawOrientation = Quaternion.Euler(startingRotation.y, startingRotation.x, 0f);
    }
}
