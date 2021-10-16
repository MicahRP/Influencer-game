using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
		//use Dialogue class we created as variable
		public Dialogue dialogue; 
		
		
		//function to locate dialogue manager and begin the dialogue (dialogue
		// variable specifies which conversation to start
		public void TriggerDialogue ()
		{
			FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
		}
}
