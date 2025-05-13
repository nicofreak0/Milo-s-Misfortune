using UnityEngine;

public class Player : MonoBehaviour
{
    static Player instance;
    public static Player Instance { get { return instance; } set { instance = value; } }


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }

        else { instance = this; }
    }
}

