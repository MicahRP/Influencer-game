using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroTextManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text introText;
    public Text otherName;
    public AudioSource typingsounds;
    public Animator dialogueAnimator;
    private Queue<string> sentences; 
    public string name1;
    public GameObject startButton;
    
    void Start(){
            sentences = new Queue<string>();
            typingsounds = GetComponent<AudioSource>();

    }
    
    public void StartIntro (Dialogue dialogue)   
    {	
            otherName.text = name1;
            //makes buttons no longer visible when dialog begins
            //now players can't switch choices mid-scene
            //New for animation
            dialogueAnimator.SetBool("IsOpen", true);
            startButton.SetActive(false);
            //set same the inputted nametag NEW if it is not the Username
            // if (nameText.text != "username"){
            // nameText.text = dialogue.name;
            // //DOES NOT RETURN THE USER'S IMPUT
            // Debug.Log (NameController.playerName);
            // } else {
            // //THIS DOES NOT WORK RN
            // nameText.text = NameController.playerName;
            // }

            sentences.Clear();
            
            //loop through sentences in dialogue and add them to Queue of sentences
            foreach (string sentence in dialogue.sentences)
            {
                    sentences.Enqueue(sentence);
            }
                    
            DisplayNextIntro();
    }
    
    public void DisplayNextIntro()
    {	
            if (sentences.Count == 0)
            {	
                    EndIntro();
                    return;
            }
            
            string sentence = sentences.Dequeue();

            //NEW changed to coroutines to show word by word
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
    }
    
    IEnumerator TypeSentence (string sentence)
    {	
            typingsounds.Play();

            //set as empty then loop through all characters in sentence(yeilds slow text)
            introText.text = "";
            foreach (char letter in sentence.ToCharArray())
            {
                    introText.text += letter;
                    yield return null; yield return null; yield return null;
            }
            yield return new WaitForSeconds(1);
            typingsounds.Stop();
    }
    
    public void EndIntro()
    {
            Debug.Log("End of conversation.");
            //NEW for animation (leaving screen)
            //dialogueAnimator.SetBool("IsOpen", false);
            sentences.Clear();
            //when textbox is gone next button appears
            //nextButton.SetActive(true);        
    }
    
    
}
