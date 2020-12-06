using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    private string[] dialogue;
    private DialogueManager dialogueManager;

    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();

        if(dialogueManager == null){
            Debug.LogWarning("No hay manejador de dialogo");
        }
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){
            dialogueManager.getDialogue(dialogue);
        }
    }

    void OnTriggerExit(Collider col){
        if(col.gameObject.tag == "Player"){
            dialogueManager.continueDialogues();
        }
    }
}
