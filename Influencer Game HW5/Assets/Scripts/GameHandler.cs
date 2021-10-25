using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{

        public static int playerStat;
        //public GameObject textGameObject;

        //void Start () { UpdateScore (); }

        void Update(){         //delete this quit functionality when a Pause Menu is added
                if (Input.GetKey("escape")){
                        Application.Quit();
                }
        }

        public void RestartGame(){
                SceneManager.LoadScene("StartMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
}