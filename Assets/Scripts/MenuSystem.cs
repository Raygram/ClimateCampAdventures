using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class MenuSystem : MonoBehaviour
{    
    [SerializeField] public GameObject menu;
    [SerializeField] public GameObject menuButton;
    [SerializeField] public GameObject quest1Trigger;
    [SerializeField] public GameObject quest2Trigger;
    [SerializeField] public GameObject quest3TriggerA;
    [SerializeField] public GameObject quest3TriggerB;

    [SerializeField] public Button quest1Button;
    [SerializeField] public Button quest2Button;
    [SerializeField] public Button quest3Button;

    private bool quest1Complete;
    private bool quest2Complete;
    private bool quest3Complete;

    // Start is called before the first frame update
    void Start()
    {
        quest1Complete = false;
    }

    // Update is called once per frame
    void Update()
    {
        ToggleMenu();
        if (quest1Complete == false)
        {
            CheckQuest1();
        }
        if (quest2Complete == false)
        {
            CheckQuest2();
        }
        if (quest3Complete == false)
        {
            CheckQuest3();
        }
    }

    private void ToggleMenu()
    {
        if (Input.GetKeyDown("m"))
        {   if (menu.activeSelf == true)
            {
                menu.SetActive(false);
                menuButton.SetActive(true);
            }
            else
            {
                menu.SetActive(true);
                menuButton.SetActive(false);
            }
        }
    }
    
    private void CheckQuest1()
    {
       if (quest1Trigger.GetComponent<BaseBorder>().GetCompleted())
       {
           if (menu.activeSelf == false)
           {
               menu.SetActive(true);
               menuButton.SetActive(false);
           }
           
           quest1Button.enabled = false;
           quest1Complete = true;
       }
    }
    private void CheckQuest2()
    {
        if (quest2Trigger.GetComponent<FenceOpen>().getOpened())
        {
            if (menu.activeSelf == false)
            {
                menu.SetActive(true);
                menuButton.SetActive(false);
            }
            quest2Button.enabled = false;
            quest2Complete = true;
        }
    }
    private void CheckQuest3()
    {
       if (quest3TriggerA.GetComponent<DiggerCollider>().GetCompleted())
       {
           if (menu.activeSelf == false)
           {
               menu.SetActive(true);
               menuButton.SetActive(false);
           }
           
           quest3Button.enabled = false;
           quest3Complete = true;
       }
        if (quest3TriggerB.GetComponent<DiggerCollider>().GetCompleted())
       {
           if (menu.activeSelf == false)
           {
               menu.SetActive(true);
               menuButton.SetActive(false);
           }
           
           quest3Button.enabled = false;
           quest3Complete = true;
       }
    }
}
