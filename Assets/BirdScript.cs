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

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

}
