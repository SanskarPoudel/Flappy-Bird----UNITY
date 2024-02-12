using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        myRigidbody.gravityScale = 0;
        myRigidbody.isKinematic = true;
    }

    void Update()
    {
        if (logic.gameStarted && birdIsAlive)
        {
            myRigidbody.gravityScale = 4;
            myRigidbody.isKinematic = false;

            if (Input.GetMouseButtonDown(0))
            {
                myRigidbody.velocity = Vector2.up * flapStrength;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        myRigidbody.velocity = Vector2.zero;
        myRigidbody.isKinematic = true;
    }
}
