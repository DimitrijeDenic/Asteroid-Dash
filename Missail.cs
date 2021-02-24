using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missail : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

 


    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -screenBounds.x * 2)
        {
            Destroy(this.gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "asteroid")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }


        if (other.tag == "collision")
        {
           
            Destroy(this.gameObject);
        }




    }


}
