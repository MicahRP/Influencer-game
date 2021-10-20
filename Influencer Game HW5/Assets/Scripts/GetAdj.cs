using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetAdj : MonoBehaviour
{
    public InputField InputAdj;
    public static string adj;

  //function is called on get adjective input box
    public void getAdj(){
            adj = InputAdj.text;
    }
}
