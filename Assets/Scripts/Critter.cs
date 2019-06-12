using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Critter : MonoBehaviour
{

    public int index;
    public bool isMovable;
    public int health;
    public int maxReach;
    public int x;
    public int y;
    //public bool IsSelect;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovable && maxReach > 0)
        {
            // Ant
            if (index == 0)
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    if (x % 2 == 1)
                        y++;
                    x++;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.A))
                {
                    if (x % 2 == 1)
                        y++;
                    x--;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    y--;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    y++;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (x % 2 == 0)
                        y--;
                    x++;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    if (x % 2 == 0)
                        y--;
                    x--;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (x < 0)
                    x = 0;
                if (x > 15)
                    x = 15;
                if (y < 0)
                    y = 0;
                if (y > 14)
                    y = 14;
                float tempx = (float)(0.54 * x) - 4;
                float tempy = (float)(4.3 - 0.6 * y);
                if (x % 2 == 1)
                {
                    tempy -= (float)0.3;
                }
                this.gameObject.transform.position = new Vector3(tempx, tempy, 0);
            }
            // Antlion
            else if (index == 1)
            {
                if (Input.GetKeyDown(KeyCode.L))
                {
                    if (x % 2 == 1)
                        y++;
                    x++;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.J))
                {
                    if (x % 2 == 1)
                        y++;
                    x--;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.I))
                {
                    y--;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.K))
                {
                    y++;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.O))
                {
                    if (x % 2 == 0)
                        y--;
                    x++;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.U))
                {
                    if (x % 2 == 0)
                        y--;
                    x--;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (x < 0)
                    x = 0;
                if (x > 15)
                    x = 15;
                if (y < 0)
                    y = 0;
                if (y > 14)
                    y = 14;
                float tempx = (float)(0.54 * x - 4.08);
                float tempy = (float)(4.0 - 0.6 * y);
                if (x % 2 == 1)
                {
                    tempy -= (float)0.3;
                }
                this.gameObject.transform.position = new Vector3(tempx, tempy, 0);
            } else
            {
                if (Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.D))
                {
                    if (x % 2 == 1)
                        y++;
                    x++;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.A))
                {
                    if (x % 2 == 1)
                        y++;
                    x--;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.W))
                {
                    y--;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.S))
                {
                    y++;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.E))
                {
                    if (x % 2 == 0)
                        y--;
                    x++;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.Q))
                {
                    if (x % 2 == 0)
                        y--;
                    x--;
                    if (x >= 0 && x <= 15 && y >= 0 && y <= 14)
                        maxReach--;
                }
                if (x < 0)
                    x = 0;
                if (x > 15)
                    x = 15;
                if (y < 0)
                    y = 0;
                if (y > 14)
                    y = 14;
                float tempx = (float)(0.54 * x - 4.08);
                float tempy = (float)(4.0 - 0.6 * y);
                if (x % 2 == 1)
                {
                    tempy -= (float)0.3;
                }
                this.gameObject.transform.position = new Vector3(tempx, tempy, 0);
            }
        }


    }

    public void setIndex(int i, int j)
    {
        x = i;
        y = j;
    }
}
