using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRocket : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public GameObject rocketPrefab;
    public float respawnTime = 1.0f;

    // Use this for initialization
    void Start()
    {
      
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        StartCoroutine(missailWave());

    }

    // Update is called once per frame
   
    private void spawnMissail()
    {
        GameObject rocket = Instantiate(rocketPrefab, transform.position, transform.rotation) as GameObject;


    }

    IEnumerator missailWave()
    {

        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnMissail();

        }


    }
}
