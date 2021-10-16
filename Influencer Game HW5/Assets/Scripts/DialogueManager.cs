using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{	
	//these two variables used to display text later
	public Text nameText;
	public Text dialogueText;
	//keeps track of all sentences in current dialogue (can be changed)
	private Queue<string> sentences; 

    // Start is called before the first frame update
    void Start()
    {		
			//create queue of strings called "sentences"
			sentences = new Queue<string>();
    }
		
		//starts conversation of Dialogue class passed into function
		public void StartDialogue (Dialogue dialogue)   
		{
			//set same the inputted nametag
			nameText.text = dialogue.name;

			sentences.Clear();
			
			//loop through sentences in dialogue and add them to Queue of sentences
			foreach (string sentence in dialogue.sentences)
			{
				sentences.Enqueue(sentence);
			}
				
			DisplayNextSentence();
		}
		
		
		public void DisplayNextSentence()
		{	
			Debug.Log("YOU HAVE PRESSED THE BUTTON");
			if (sentences.Count == 0)
			{	
				EndDialogue();
				return;
			}
			
			string sentence = sentences.Dequeue();
			dialogueText.text = sentence;
		}

		void EndDialogue()
		{
			Debug.Log("End of conversation.");
		}

}