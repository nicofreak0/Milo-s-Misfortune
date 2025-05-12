using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportBetweenScenes : MonoBehaviour
{
    [Tooltip("The name of the scene to load.")]
    public string targetSceneName;

    [Tooltip("The tag of the player GameObject.")]
    public string playerTag = "Player";

    [Tooltip("The name of the GameObject in the target scene to teleport the player to. Leave empty to spawn at the scene's default.")]
    public string targetMarkerName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            // Store the target marker name
            SceneTeleporter.targetMarker = targetMarkerName;

            // Get the player GameObject
            GameObject player = other.gameObject;

            // Load the target scene
            SceneManager.LoadScene(targetSceneName);
        }
    }
}

// Static class to carry information between scene loads
public static class SceneTeleporter
{
    public static string targetMarker = null;
    public static GameObject playerToMove = null; // Add this line
}
