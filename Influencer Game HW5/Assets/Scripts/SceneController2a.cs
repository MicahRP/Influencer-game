using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController2a : MonoBehaviour
{

    public void OnButtonPress(){
        Debug.Log("You have pressed the button");
        SceneManager.LoadScene("SampleScene"); //change to title of next scene to link
    }
}
