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

    public void StartPostViralVid(){
        SceneManager.LoadScene("PostViralVid");
    }

    public void StartFirstPost(){
        SceneManager.LoadScene("FirstPost");
    }

   public void AfterViralPost(){
        SceneManager.LoadScene("AfterViralPost");
    }

   public void Aftermadlibs2(){
        SceneManager.LoadScene("Aftermadlibs2");
    }

   public void StartCommentB4Madlibs(){
        SceneManager.LoadScene("CommentB4Madlibs");
    }

   public void StartMadLibs(){
        SceneManager.LoadScene("MadLibs");
    }
	public void StartMadlibs2(){
        SceneManager.LoadScene("Madlibs2");
    }

   public void StartMadlibs3(){
        SceneManager.LoadScene("Madlibs3");
    }

   public void StartAfterMadLibs(){
        SceneManager.LoadScene("AfterMadLibs");
    }
}
