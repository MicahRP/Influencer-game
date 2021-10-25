using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowerController : MonoBehaviour
{

    string followerCount;
    public static float followerNum;
    public static bool isFalling;
    public Text followerText;
    
    //Related to image
    public static char imageChoice;

    //On start
    void Start() {
        followerCount = FollowerController.followerNum + "k followers";
        followerText.text = followerCount;
        imageChoice = 'B';
    }

    //Initialize a follower count of 0
    public void zeroFollowers() {
        followerNum = 0;
        isFalling = false;
        followerCount = followerNum + "k followers";
        followerText.text = followerCount;
    }

    //Updates follower count
    public void updateFollowers(float num) {
        if(imageChoice == 'A'){
            num += 5;
        }
        if (isFalling == true) {
            num = 0 - num;
        }
        followerNum = followerNum + num;
        if (followerNum < 0) {
            followerNum = 0;
        }
        followerCount = followerNum + "k followers";
        followerText.text = followerCount;
    }
    
    public void randUpdateFollowers() {
        float random = (Random.Range(0, 100))/10;
        if(imageChoice == 'A'){
                random += 5;
        }
        if (isFalling == true) {
            random = 0 - random;
        }
        followerNum = followerNum + random;
        if (followerNum < 0) {
            followerNum = 0;
        }
        followerCount = followerNum + "k followers";
        followerText.text = followerCount;
    }
    
    public void setFalling(){
          isFalling = true;
    }

    //Set which image choic
    public void imageA() {
        imageChoice = 'A';
    }
    public void imageB() {
        imageChoice = 'B';
    }
}
