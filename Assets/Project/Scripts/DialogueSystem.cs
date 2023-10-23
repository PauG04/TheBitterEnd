using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField, TextArea(4,3)]
    private string[] dialogueLines;
    [SerializeField]
    private GameObject dialoguePanel;
    [SerializeField]
    private TMP_Text dialogueText;
    [SerializeField]
    private float separation;
    private int lineIndex;

    public void startDialogue()
    {
        lineIndex = Random.Range(0, dialogueLines.Length + 1);
        dialoguePanel.SetActive(true);
        dialogueText.text = dialogueLines[lineIndex];    
    }
}
    
