using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class MenuSystem : MonoBehaviour
{    
    [SerializeField] public GameObject menu; // contains all the subelements, used to toggle the menu in the game
    [SerializeField] public GameObject menuButton; // button whose press opens the menu
    [SerializeField] public GameObject endMessage; // message displayed after all quests have been completed
    [SerializeField] public GameObject quest1Trigger; // triggers for the different quests
    [SerializeField] public GameObject quest2Trigger; 
    [SerializeField] public GameObject quest3TriggerA;
    [SerializeField] public GameObject quest3TriggerB;

    [SerializeField] public Button quest1Button; // buttons for the quests in the menu
    [SerializeField] public Button quest2Button;
    [SerializeField] public Button quest3Button;

    private bool quest1Complete; // booleans for the status of the quests
    private bool quest2Complete;
    private bool quest3Complete;
    private bool endMessageShown;

    // Start is called before the first frame update
    void Start()
    {
        quest1Complete = false;
        quest2Complete = false;
        quest3Complete = false;
    }

    // Update is called once per frame
    void Update()
    {
        // check if menu is opened or closed
        ToggleMenu();
        // check whether the quests have been completed
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
        // if all 3 quests are completed show the end message (if it hasn't been shown before)
        if ((!endMessageShown) && (quest1Complete) && (quest2Complete) && (quest3Complete))
        {
            menu.SetActive(false);
            endMessage.SetActive(true);
            endMessageShown = true;
        }
    }

    private void ToggleMenu()
    {   // if m is pressed:
        if (Input.GetKeyDown("m"))
            // if menu is active: close it and activate menu button
        {   if (menu.activeSelf == true)
            {
                menu.SetActive(false);
                menuButton.SetActive(true);
            }
            // else: open it and deactivate menu button
            else
            {
                menu.SetActive(true);
                menuButton.SetActive(false);
            }
        }
    }
    
    private void CheckQuest1()
    {
        // get a boolean from the BaseBorder Script, that is true if the base was left
        if (quest1Trigger.GetComponent<BaseBorder>().GetCompleted())
       {    
           // open menu to show quest progress (if it isn't already)
           if (menu.activeSelf == false)
           {
               menu.SetActive(true);
               menuButton.SetActive(false);
           }
           // deactivate the quest button
           quest1Button.enabled = false;
           // quest 1 complete
           quest1Complete = true;
       }
    }
    private void CheckQuest2()
    {   // get a boolean from the FenceOpen Script, that is true if the fence was opened
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
    {   // if either Digger A or Digger B was touched, quest 3 is complete
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
