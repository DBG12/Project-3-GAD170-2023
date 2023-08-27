using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    //similar to the pressureplate on trigger?? collision of the player?


    public bool movingElevator = false;

    // Start is called before the first frame update
    void Start()
    {
        // Time.timeScale=(0.7f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.transform.position.y < 11 && movingElevator)
        {
            this.transform.position += new Vector3(0, 0.04f, 0);//MOVE
        }
    }
}