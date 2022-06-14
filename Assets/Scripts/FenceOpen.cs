using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceOpen : MonoBehaviour
{
    //[SerializeField] 
    //public KeyCode openFenceKey = KeyCode.Mouse0;
    
    // open fence once
    private bool opened;
    
    [SerializeField]
    public float openingrange = 5f;

    [SerializeField] 
    private Transform actor;

    [SerializeField] 
    private Transform target;

    void Update()
    {   
        // Raycast info - did it hit something
        RaycastHit hit;

        if (Input.GetKey(KeyCode.E))
        {   
            // if the ray hit something in the range 
            if (Physics.Raycast(actor.transform.position, Vector3.forward, out hit, openingrange))
            {   
                // and what it hit is a fence, and it's not open yet - open the fence
                if (hit.collider.CompareTag("Fence"))
                {
                    if (!opened)
                    {
                        OpenFence();
                        Debug.Log("You hit the fence");
                        
                    }
                }

            }
        }
    }

    // Function for opening the fence, then setting open to true so it doesn't repeat
    void OpenFence()
    {
        Debug.DrawRay(actor.transform.position, Vector3.forward, Color.blue);
        target.Rotate(0f, 60f,0f);
        opened = true;
    }
}