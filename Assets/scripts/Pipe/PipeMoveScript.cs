using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -45;

    private LogicScript logicScript;

    void Start()
    {

        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();


    }

    // Update is called once per frame
    void Update()
    {

        if (logicScript.gameStarted == true)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

            if (transform.position.x < deadZone)
            {
                Destroy(gameObject);
            }
        }


    }
}
