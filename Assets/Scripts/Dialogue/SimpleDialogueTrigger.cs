using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDialogueTrigger : MonoBehaviour {
  public Dialogue[] dialogue;

  public void TriggerDialogue() {
    Queue<Dialogue> dialogueQueue = new Queue<Dialogue>();

    foreach (Dialogue entry in dialogue) {
      dialogueQueue.Enqueue(entry);
    }

    FindObjectOfType<DialogueManager>().StartDialogue(dialogueQueue);
  }

  public void TriggerDialogue(Dialogue[] d) {
    dialogue = d;
    TriggerDialogue();
  }
}
