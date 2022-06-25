using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FenceOpen : MonoBehaviour
{   
    // two booleans, one for pressing E and one for the fence
    private bool opened = false;
    private bool e_pressed = false;
    
    void Update()
    {
        // if you press E, the first boolean is true so that you then can open the fence
        if (Input.GetKey(KeyCode.E))
        {
            e_pressed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // if you have pressed E before and now approach a fence, open it
        if (other.CompareTag("Fence") && e_pressed)
        {
            Debug.Log("Fence opened");
            other.transform.Rotate(new Vector3(0f, 60f, 0f));
            opened = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // exit collider if you walk away from fence
        if (other.CompareTag("Fence"))
        {
            e_pressed = false;
        }
    }
    
    // return if the fence is open so that the menu system can use this info
    public bool getOpened()
    {
        return opened;
    }
}
