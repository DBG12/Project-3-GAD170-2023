using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public Elevator myElevator;
    public SoundMaker mySoundMaker;
    //this function is called by UNITY - not by me- whenever a object (with a collider+rb) collides with my trigger.
    void OnTriggerEnter(Collider collisionData)
    {
        //for the opponent(?) collider
              //get it's gameObject
                          //The NAME of the GameObject of the Collider that hit me
                                    //checked if it is "player"
         if(collisionData.name =="Player")
        {
            print("OW! The player stepped on me!");
            myElevator.movingElevator = true;
            mySoundMaker.PlaySound();
        }
    }
}
