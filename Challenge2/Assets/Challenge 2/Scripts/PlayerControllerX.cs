using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float limit= 17.0f;
    public float limit2= -53.0f;
    public float fireRate = 1;
    private float nextFire = 0.0F;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
