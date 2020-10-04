using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialEndDialogue : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Text buttonText;
    public Animator animator;
    public Animator endAnimator;
    //All Sentences from current Dialogue
    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;
        animator.SetBool("isOpen", true);
        sentences.Clear(); //Clear all Sentences from the queue for new Dialogue

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        else if (sentences.Count == 1)
        {
            buttonText.text = "Good Night";
        }
      
        string sentence = sentences.Dequeue();

        //Stop all Coroutines as Start a New One
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }

    //coRoutine to Animate Text
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            //Wait
            yield return new WaitForSeconds(0.01f);
        }
    }
    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        endAnimator.SetBool("fadeOut", true);
        Debug.Log("End Dialogue");
    }

}
