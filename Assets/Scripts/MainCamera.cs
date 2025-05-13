using UnityEngine;

public class MainCamera : MonoBehaviour
{
    static MainCamera instance;
    public static MainCamera Instance { get { return instance; } set { instance = value; } }


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }

        else { instance = this; }
    }
}
