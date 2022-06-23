using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BaseBorder : MonoBehaviour
{
    public bool leftBase;

    public bool GetCompleted()
    {
        return leftBase;
    }

    // Start is called before the first frame update
    void Start()
    
    {
        leftBase = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            leftBase = true;
            this.gameObject.SetActive(false);
        }
    }
}
