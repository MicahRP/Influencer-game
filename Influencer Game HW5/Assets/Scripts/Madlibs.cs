using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Madlibs : MonoBehaviour
{
        public Text displayText;
        public GameObject doneButton;
        public GameObject textBox;
        
        //extra strings to write around the inputted words **CHANGE**
        public string part1;
        public string part2; 
        public string part3;
        public string part4;
        

    void Start()
    {
            textBox.SetActive(false);
            doneButton.SetActive(true);
    }

    // Update is called once per frame
    public void displayResult(){
            //hypotheticall,y this will save the inputted words
            string noun = GetNoun.noun;
            string verb = GetVerb.verb;
            string adj = GetAdj.adj;
            doneButton.SetActive(false);
            textBox.SetActive(true);
            //print concattenated string in the textbox
            displayText.text = part1 + noun + part2 + verb + part3 + adj + part4;
    }
}
