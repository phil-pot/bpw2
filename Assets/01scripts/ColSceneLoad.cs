using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnCollision : MonoBehaviour
{
    // Name of the scene to load
    public string sceneToLoad;

    // This function is called when the collider attached to this GameObject
    // enters a collision with another collider
    private void OnCollisionEnter(Collision collision)
    {
        // Log the name of the colliding object
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        // Log that a collision was detected and the scene is being loaded
        Debug.Log("Loading scene: " + sceneToLoad);

        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
