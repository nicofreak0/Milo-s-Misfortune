using UnityEngine;

public class CameraController : MonoBehaviour
{
    private InputManager inputManager;
    private Vector3 startingRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputManager = InputManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
