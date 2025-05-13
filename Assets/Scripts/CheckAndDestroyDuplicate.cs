using UnityEngine;

public class CheckAndDestroyDuplicate : MonoBehaviour
{
    public string objectTagToCheck = "Player"; // Set the tag of the object you want to check for duplicates

    void Start()
    {
        GameObject[] foundObjects = GameObject.FindGameObjectsWithTag(objectTagToCheck);

        if (foundObjects.Length > 1)
        {
            // We found more than one object with the specified tag.
            // You might want to define a specific object to keep and destroy the others.
            // For this example, we'll destroy the one that isn't this GameObject.

            foreach (GameObject obj in foundObjects)
            {
                if (obj != gameObject)
                {
                    Debug.Log($"Duplicate '{objectTagToCheck}' found. Destroying: {obj.name}");
                    Destroy(obj);
                }
            }
        }
    }
}