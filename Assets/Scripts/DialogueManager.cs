using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private static DialogueManager instance { get; set; }

    [SerializeField]
    private GameObject dialoguePanel;
    private Text dialogueText;

    private int dialogueIndex;
    private List<string> dialogueList = new List<string>();

    private void Awake(){
        if(instance != null && instance != this){
            Destroy(gameObject);
            return;
        }else{
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start(){
        if(dialoguePanel == null){
            Debug.LogWarning("Falta panel de dialogo");
        }

        dialogueText = dialoguePanel.transform.GetComponentInChildren<Text>();

        if(dialogueText == null){
            Debug.LogWarning("No se encontro texto de dialogo");
        }

        dialogueText.text = "Dialogo del personaje";

        dialoguePanel.SetActive(false);
    }

    public void getDialogue(string[] dialogue){
        dialoguePanel.SetActive(true);
        dialogueIndex = 0;
        dialogueList = new List<string>(dialogue.Length);
        dialogueList.AddRange(dialogue);
        createDialogues();
    }

    public void createDialogues(){
        dialogueText.text = dialogueList[dialogueIndex];
    }

    public void continueDialogues(){
        if(dialogueIndex < dialogueList.Count - 1){
            dialogueIndex++;
            createDialogues();
        }
        else{
            dialoguePanel.SetActive(false);
        }
    }
}
