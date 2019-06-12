using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntlionBehaviour : MonoBehaviour
{
    public int health = 4;

    void Start()
    {
        print("Start");


    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.position += new Vector3(0.03f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.position += new Vector3(-0.03f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.transform.position += new Vector3(0, 0.03f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.transform.position += new Vector3(0, -0.03f, 0);
        }
    }
}