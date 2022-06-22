using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FenceOpen : MonoBehaviour
{
    private bool opened = false;
    private bool e_pressed = false;
    
    void Update()
    {
        // if you press E, a boolean is true so that you then can open the fence
        if (Input.GetKey(KeyCode.E))
        {
            e_pressed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // if you have pressed E and now approach a fence, open it
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

    public bool getOpened()
    {
        return opened;
    }
}
