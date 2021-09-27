using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    static DialogueManager _instance;
    public static DialogueManager Singleton()
    {
        if(_instance == null)
        {
            _instance = FindObjectOfType<DialogueManager>();
        }

        return _instance;
    }
    
    public void Talk(string text)
    {
        Debug.Log(text);
    }
}
