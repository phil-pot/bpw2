using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public float water = 100f;
    public ParticleSystem particleSystem;
    public GameObject spark;
    //public GameObject targetObject;
    public float upwardForce = 1f;

    List<ParticleCollisionEvent> colEvents = new List<ParticleCollisionEvent>();

    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (particleSystem.isPlaying)
            {
                particleSystem.Stop();
            }
            else
            {
                particleSystem.Play();
            }
        }
    }

    //private void OnParticleCollision(GameObject other)
    //{
    //    int numCollisionEvents = particleSystem.GetCollisionEvents(other, colEvents);

    //    for (int i = 0; i < numCollisionEvents; i++)
    //    {
    //        if (other.CompareTag("Target"))
    //        {
    //            Debug.Log("plantje omhoog");
    //            Vector3 moveUp = new Vector3(0, upwardForce, 0);
    //            targetObject.transform.position += moveUp;
    //        }
    //    }
    //}
}
