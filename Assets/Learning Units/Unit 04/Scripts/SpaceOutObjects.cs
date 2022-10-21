using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceOutObjects : MonoBehaviour
{
    // DIRECTIONS: The goal of this Unit is to get the objects to space out evenly

    // Start is called before the first frame update
    void Start()
    {
        // DIRECTION: Uncomment the lines below, then fix them...
        objectsToSpaceOut = new List<MoveObjects>();
        
        for (int i=0; i < objectsToSpaceOut.Count; i++)
        {
           objectsToSpaceOut[i].transform.position = new Vector3(i * 2f,0,0);
        }

    GetComponent<MoveObjects>().enabled = false; // Keep this line. We've got these objects from this 
    //     // Component, and we don't need it anymore
    }

    // // Update is called once per frame
    void Update()
    {
        
    }
}