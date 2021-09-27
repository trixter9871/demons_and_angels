using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InitDialogue : MonoBehaviour
{
    public Dialogue dialogue;
    int currentMessageIndex = 0;
    public TextMeshPro tmp;
    
    BoxCollider box;

    void Start () 
    {
        tmp.gameObject.SetActive(false);
        box = GetComponent<BoxCollider>();
        //box.enabled = false;
    }
    
    public bool isPlayerInBoxBefore = false;
    
    void Update()
    {
        Vector3 playerPos = Player.GetPlayer().transform.localPosition;
        //Debug.DrawLine(box.transform.position, playerPos, Color.red, 0);
        bool isPlayerInBoxNow = box.bounds.Contains(playerPos);
        
        if(isPlayerInBoxNow)
        {
            if(isPlayerInBoxBefore)
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    OnPlayerInteraction();
                }
            }
            else
            {
                isPlayerInBoxBefore = true;
                OnPlayerEnterBox();
            }
        }
        else
        {
            if(isPlayerInBoxBefore)
            {
                isPlayerInBoxBefore = false;
                OnPlayerExitBox();
            }
            else
            {
                // Do nothing...
            }
        }
        
    }
    
    void OnPlayerInteraction()
    {
        if(currentMessageIndex < dialogue.sentences.Length) 
        {
            int i = currentMessageIndex;
            tmp.gameObject.SetActive(true);
            tmp.SetText(dialogue.sentences[i]);
            currentMessageIndex++;
        }
        else 
        {
            tmp.gameObject.SetActive(false);
        }
    }
    
    void OnPlayerEnterBox()
    {
        Debug.Log("<color=yellow>OnPlayerEnterBox()</color>");
    }
    
    void OnPlayerExitBox()
    {
        currentMessageIndex = 0;
        Debug.Log("OnPlayerExitBox()");
    }
    

    // void OnTriggerStay(Collider other) 
    // {
    //     if(Input.GetKeyDown(KeyCode.E)) 
    //     {   
    //         if (currentMessageIndex < dialogue.sentences.Length) 
    //         {
    //             int i = currentMessageIndex;
    //             tmp.gameObject.SetActive(true);
    //             tmp.SetText(dialogue.sentences[i]);
    //             currentMessageIndex++;
    //         }
    //         else 
    //         {
    //             tmp.gameObject.SetActive(false);
    //         }
    //     }
    // }

    // void OnTriggerExit(Collider other)
    // {
    //     currentMessageIndex = 0;
    // }
}
