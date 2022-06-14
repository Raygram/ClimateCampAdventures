using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceOpen : MonoBehaviour
{
    //[SerializeField] 
    //public KeyCode openFenceKey = KeyCode.Mouse0;

    private bool opened;
    
    [SerializeField]
    public float openingrange = 5f;

    void Update()
    {
        RaycastHit hit;

        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(transform.position, Vector3.forward, out hit, openingrange))
            {
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

    void OpenFence()
    {
        Debug.DrawRay(transform.position, Vector3.forward, Color.blue);
        
        opened = true;
    }
        
        
    /*void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, _raylength))
        {
            if (hit.collider.CompareTag("Fence"))
            {
                if (!opened)
                {
                    opened = true;
                }
            }
        } */
}

