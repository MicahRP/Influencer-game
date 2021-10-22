using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameController : MonoBehaviour
{
    public InputField InputFieldName;
    public static string playerName;
	public GameObject doneButton;
    public Text NameboxText;



    public void getName() {
        
        playerName = InputFieldName.text;
        NameboxText.text = playerName;
		doneButton.SetActive(false);


    }

    void start() {

		doneButton.SetActive(true);
        NameboxText.text = playerName;
    }
}
