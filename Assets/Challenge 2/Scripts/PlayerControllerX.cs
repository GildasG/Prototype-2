using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canSpawn = true;
    private float spawnDelay = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetButtonDown("Fire1"))
        {
            if (canSpawn)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                // Set the dogprefab unspawnable right after being spawned
                canSpawn = false;

                // Invoke the abilty to spawn again a dog after a delay
                Invoke("SetCanSpawn", spawnDelay);
            }
        }
    }
        void SetCanSpawn()
    {
        // Reset the spawning status of the dog
        canSpawn = true;
    }
}
