using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetNoun : MonoBehaviour
{
    public InputField InputNoun;
    public static string noun;

  //function is called on get noun input box
    public void getNoun(){
            noun = InputNoun.text;
    }
}
