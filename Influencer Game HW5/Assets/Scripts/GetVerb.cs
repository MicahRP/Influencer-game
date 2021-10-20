using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetVerb : MonoBehaviour
{
    public InputField InputVerb;
    public static string verb;

    //function is called on get verb input box
    public void getVerb(){
            verb = InputVerb.text;
    }
}
