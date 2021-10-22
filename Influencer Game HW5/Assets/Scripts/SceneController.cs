using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

   public void StartSampleScene(){
        SceneManager.LoadScene("SampleScene");
    }

   public void StartPickUsername(){
        SceneManager.LoadScene("PickUsername");
    }

   public void StartScene2a(){
        SceneManager.LoadScene("Scene2a");
    }

   public void StartScene2b(){
        SceneManager.LoadScene("Scene2b");
    }
    
}
