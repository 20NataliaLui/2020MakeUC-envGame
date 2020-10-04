using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    /*
        public void TriggerDialogue()
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        */
    // called second

    public void Start()
    {


        StartCoroutine(wait());
        
    }

    //Wait For x secons than Start Dialogue
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        if (FindObjectOfType<DialogueManager>() != null)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else
        {
            FindObjectOfType<SpecialEndDialogue>().StartDialogue(dialogue);
        }
    }
}
