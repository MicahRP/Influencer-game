using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BranchDialogueManager : MonoBehaviour
{	
	//these two variables used to display text later
	public Text nameText;
	public Text dialogueText;
	//keeps track of all sentences in current dialogue (can be changed)
	private Queue<string> Asentences;
        private Queue<string> Bsentences;  
        private Queue<string> names; 
        private bool choice = true;

    // Start is called before the first frame update
    void Start()
    {		
			//create queue of strings called "sentences"
			Asentences = new Queue<string>();
                        Bsentences = new Queue<string>();
                        
    }
		
		//starts conversation of Dialogue class passed into function
		public void StartDialogueA (BranchDialogue branchdialogue)   
		{
			//set same the inputted nametag
			choice = true;
                        nameText.text = branchdialogue.name;
			Asentences.Clear();
			
			//loop through sentences in dialogue and add them to Queue of sentences
			foreach (string Asentence in branchdialogue.Asentences)
			{
				Asentences.Enqueue(Asentence);
			}
                        	
			DisplayNextSentence();
		}
		
                
                public void StartDialogueB (BranchDialogue branchdialogue)   
		{
			//set same the inputted nametag
                        choice = false;
			nameText.text = branchdialogue.name;
			Bsentences.Clear();
			
			//loop through sentences in dialogue and add them to Queue of sentences
			foreach (string Bsentence in branchdialogue.Bsentences)
			{
				Bsentences.Enqueue(Bsentence);
			}
                        	
			DisplayNextSentence();
		}
		
		
		public void DisplayNextSentence()
		{	
                        Debug.Log("YOU HAVE PRESSED THE BUTTON");
                        if(choice == true){
                                if (Asentences.Count == 0)
        			{	
        				EndDialogue();
        				return;
        			}
        			
        			string Asentence = Asentences.Dequeue();
        			dialogueText.text = Asentence;
                        } else {
                                if (Bsentences.Count == 0)
        			{	
        				EndDialogue();
        				return;
        			}
        			
        			string Bsentence = Bsentences.Dequeue();
        			dialogueText.text = Bsentence;
                        }
			
		}

		void EndDialogue()
		{
			Debug.Log("End of conversation.");
		}
                
                

}