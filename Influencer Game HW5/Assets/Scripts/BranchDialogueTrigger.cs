using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchDialogueTrigger : MonoBehaviour
{
		//use Dialogue class we created as variable
		public BranchDialogue branchdialogue; 
		
		//function to locate dialogue manager and begin the dialogue (dialogue
		// variable specifies which conversation to start
		public void TriggerDialogueA ()
		{
			FindObjectOfType<BranchDialogueManager>().StartDialogueA(branchdialogue);
		}
                
                public void TriggerDialogueB ()
		{
			FindObjectOfType<BranchDialogueManager>().StartDialogueB(branchdialogue);
		}
}
