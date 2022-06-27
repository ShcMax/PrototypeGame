using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerManager
{
    private float speed;
    private int health;
    private float hor;
    private float vert;
    // Start is called before the first frame update
    void Start()
    {
        speed = PlayerSpeed;
        health = PlayerHealth;        
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 0)
        {
            Destroy(gameObject);
        }       
    }
    private void FixedUpdate()
    {
        Movement();
    }

    public void Movement()
    {
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hor, 0, vert) * speed * Time.deltaTime);
    }
}
