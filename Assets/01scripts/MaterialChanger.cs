using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public Material newMaterial;  // The material to switch to
    public int maxTries = 3;      // Maximum number of attempts
    private int currentTries = 0; // Counter for attempts

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Collision detected with target object: " + collision.gameObject.name);

            if (currentTries < maxTries)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Key pressed to change material.");

                    MeshRenderer renderer = collision.gameObject.GetComponent<MeshRenderer>();
                    if (renderer != null)
                    {
                        renderer.material = newMaterial;
                        currentTries++;
                        Debug.Log("Material changed. Attempts left: " + (maxTries - currentTries));
                    }
                    else
                    {
                        Debug.LogWarning("No MeshRenderer found on target object.");
                    }
                }
            }
            else
            {
                Debug.Log("No tries left.");
            }
        }
    }

    void Update()
    {
        // Checking key press in Update to ensure it gets detected
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Key E pressed.");
        }
    }
}
