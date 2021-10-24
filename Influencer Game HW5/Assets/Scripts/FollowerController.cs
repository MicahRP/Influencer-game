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

    //On start
    void Start() {
        followerCount = FollowerController.followerNum + "k followers";
        followerText.text = followerCount;
    }

    //Initialize a follower count of 0
    public void zeroFollowers() {
        followerNum = 0;
        isFalling = false;
        followerCount = followerNum + "k followers";
        followerText.text = followerCount;
    }

    //Updates follower count
    public void upadateFollowers(float num) {
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
}
