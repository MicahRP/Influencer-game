using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameController : MonoBehaviour
{
    public InputField InputFieldName;
    public static string playerName;
    public Text NameboxText;



    public void getName() {
        
        playerName = InputFieldName.text;
        NameboxText.text = playerName;
        // SceneManager.LoadScene("Scene 2a");


    }

    void start() {
        NameboxText.text = playerName;
    }
}
