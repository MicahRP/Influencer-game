using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{	
	//these two variables used to display text in boxes
	public Text nameText;
	public Text dialogueText;
	
	//NEW varable used to send dialogue box in + out, audio variable
	public Animator dialogueAnimator;
	public AudioSource typingsounds;

	//keeps track of all sentences in current dialogue (can be changed)
	private Queue<string> sentences; 

    // Start is called before the first frame update
    void Start()
    {		
			//create queue of strings called "sentences"
			sentences = new Queue<string>();
			typingsounds = GetComponent<AudioSource>();
    }
		
		//starts conversation of Dialogue class passed into function
		public void StartDialogue (Dialogue dialogue)   
		{	
			//New for animation
			dialogueAnimator.SetBool("IsOpen", true);

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

			//NEW changed to coroutines to show word by word
			StopAllCoroutines();
			StartCoroutine(TypeSentence(sentence));
		}

		//NEW added function to type word by word with typing sounds
		IEnumerator TypeSentence (string sentence)
		{	
			typingsounds.Play();

			//set as empty then loop through all characters in sentence(yeilds slow text)
			dialogueText.text = "";
			foreach (char letter in sentence.ToCharArray())
			{
				dialogueText.text += letter;
				yield return null; yield return null; yield return null;
				yield return null; yield return null; yield return null;

			}
			yield return new WaitForSeconds(1);
			typingsounds.Stop();
		}

		void EndDialogue()
		{
			Debug.Log("End of conversation.");
			//NEW for animation (leaving screen)
			dialogueAnimator.SetBool("IsOpen", false);
		}

}