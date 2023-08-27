using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Test Raw after Axis
    // Update is called once per frame
    void Update()
    {
        Vector3 userInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        {
            this.transform.position += new Vector3(0, 0, 0.01f);
        }
    }
}
