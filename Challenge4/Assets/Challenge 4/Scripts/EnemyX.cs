using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    private SpawnManagerX speedBoost;
    public float speed = 100;
    private Rigidbody enemyRb;
    public GameObject playerGoal;

    // Start is called before the first frame update
    void Start()
    {
        speedBoost = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerX>();
        speed= speedBoost.enemySpeed;
        enemyRb = GetComponent<Rigidbody>();
        playerGoal =GameObject.Find("Player Goal");
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }

}
