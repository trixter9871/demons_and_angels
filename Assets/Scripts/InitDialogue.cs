using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InitDialogue : MonoBehaviour
{

    public Dialogue dialogue;
    int currentMessageIndex = 0;
    public TextMeshPro tmp;

    void Start () 
    {
        tmp.gameObject.SetActive(false);
    }

    void OnTriggerStay(Collider other) 
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {   
            if (currentMessageIndex < dialogue.sentences.Length) 
            {
                int i = currentMessageIndex;
                tmp.gameObject.SetActive(true);
                tmp.SetText(dialogue.sentences[i]);
                //DialogueManager.Singleton().Talk(dialogue.sentences[i]);
                currentMessageIndex++;

                // if(currentMessageIndex == dialogue.sentences.Length)
                // {
                //     Rigidbody rb = transform.parent.gameObject.AddComponent<Rigidbody>();
                //     rb.mass = 30;
                //     rb.AddForce(50 * Random.onUnitSphere, ForceMode.Force);
                // }
            }
            else 
            {
                tmp.gameObject.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        currentMessageIndex = 0;
    }
}
