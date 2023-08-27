using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMaker : MonoBehaviour
{
    void OnEnable()
    {
        //Eventmanager.ElevatorEvent;
    }

    void OnDisable()
    {
        //Event.manager.ElevatorEvent -= PlaySound();
    }


    public void PlaySound()
    {
        this.GetComponent<AudioSource>().Play();
    }
}
