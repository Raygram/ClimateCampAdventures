using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiggerCollider : MonoBehaviour
{
    public bool touchDigger;

    public bool GetCompleted()
    {
        return touchDigger;
    }

    // Start is called before the first frame update
    void Start()
    {
        touchDigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            touchDigger = true;
        }
    
    }
}
