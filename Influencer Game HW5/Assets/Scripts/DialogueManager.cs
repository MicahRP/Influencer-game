using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        
        //NEW !!! used to control visilbility of buttons
        public GameObject scenarioBox;
        public GameObject startConvo;
        public GameObject startConvo2;
        public GameObject nextButton;

    // Start is called before the first frame update
    void Start()
    {		
			//create queue of strings called "sentences"
			sentences = new Queue<string>();
			typingsounds = GetComponent<AudioSource>();
                        
                        //makes option 1 and option 2 visible when scene starts
                        //makes next button invisible when scene starts
                        scenarioBox.SetActive(true);
                        startConvo.SetActive(true);
                        startConvo2.SetActive(true);
                        nextButton.SetActive(false);
    }
		
		//starts conversation of Dialogue class passed into function
		public void StartDialogue (Dialogue dialogue)   
		{	
                        //makes buttons no longer visible when dialog begins
                        //now players can't switch choices mid-scene
                        scenarioBox.SetActive(false);
                        startConvo.SetActive(false);
                        startConvo2.SetActive(false);
			//New for animation
			dialogueAnimator.SetBool("IsOpen", true);

			//set same the inputted nametag NEW if it is not the Username
			if (nameText.text != "username"){
			nameText.text = dialogue.name;
			//DOES NOT RETURN THE USER'S IMPUT
			Debug.Log (NameController.playerName);
			} else {
			//THIS DOES NOT WORK RN
			nameText.text = NameController.playerName;
			}

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
			}
			yield return new WaitForSeconds(1);
			typingsounds.Stop();
		}

		void EndDialogue()
		{
			Debug.Log("End of conversation.");
			//NEW for animation (leaving screen)
			dialogueAnimator.SetBool("IsOpen", false);
                        
                        //when textbox is gone next button appears
                        nextButton.SetActive(true);        
		}

}