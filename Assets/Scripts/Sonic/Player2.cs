using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed;
    public Transform player;
    public float jumpAmount;
    public bool jumped;

    float tmpPos;
    bool down;
    float temp;

    void Awake()
    {
        tmpPos = player.position.y;
    }

    void Update()
    {

        this.transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * speed);

        if (Input.GetKeyDown(KeyCode.Space) && jumped == false)
        {
            jumped = true;
        }

        if (jumped == true && temp < jumpAmount)
        {
            temp += 0.05f;
            player.Translate(0, temp, 0);
        }

        if (temp >= jumpAmount)
        {
            down = true;
        }

        if (down)
        {
            jumped = false;
            temp -= 0.05f;
            player.Translate(0, temp, 0);
        }

        if (player.position.y <= tmpPos)
        {
            down = false;
        }
    }
}
