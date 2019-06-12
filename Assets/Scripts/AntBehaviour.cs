using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntBehaviour : MonoBehaviour
{
    public bool hasEgg;
    public int health = 1;
    void Start()
    {
        print("Start");


    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(0.03f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position += new Vector3(-0.03f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += new Vector3(0, 0.03f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position += new Vector3(0, -0.03f, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Antlion")
        {
            collision.gameObject.SendMessage("ApplyDamage", 10);
        }
    }
}