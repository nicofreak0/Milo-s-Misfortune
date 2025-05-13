using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    static PlayerFollowCamera instance;
    public static PlayerFollowCamera Instance { get { return instance; } set { instance = value; } }


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }

        else {instance = this; }
    }
}
