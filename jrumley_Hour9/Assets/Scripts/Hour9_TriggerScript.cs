using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hour9_TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter (Collider other)
    {
        print(other.gameObject.name + " has collided with the " + name);
    }
    
    void OnTriggerStay (Collider other)
    {
        print(other.gameObject.name + " is still in the " + name);
    }

    void OnTriggerExit (Collider other)
    {
        print(other.gameObject.name + " has left the " + name);
    }
}
