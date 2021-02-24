using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPowerup : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public GameObject player;
    public float sec = 5f;
    public GameObject Camera;
    public string scr;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        
    }

   

    // Update is called once per frame
    void Update()
    {

        //if(Score.scoreValue == 5)
    //{
       // player.GetComponent<ShootingRocket>().enabled = true;
    //}
        
       if (transform.position.x < screenBounds.x)
      {
          Destroy(this.gameObject);
       }
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log("Picked up!");



            StartCoroutine(Pickup(other));

            Debug.Log("coroutine started");



        }

       
    }

   IEnumerator Pickup(Collider2D player)
    {

       
        player.GetComponent<ShootingRocket>().enabled = true;

        Debug.Log("shooting enabled");


        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        Debug.Log("components hidden");

        Debug.Log("starting to wait");


        yield return new WaitForSeconds(5f);

        Debug.Log("Wait finnished");


        Debug.Log("Disableing!");

        player.GetComponent<ShootingRocket>().enabled = false;

        Debug.Log("disabled");


        Destroy(gameObject);

        Debug.Log("destroyed");

    }



}