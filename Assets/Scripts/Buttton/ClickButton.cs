using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    private Color currentColor = ButtonColorControl.currentColor;
    private int colorNumber = ButtonColorControl.colorNumber;
    public static bool isClicked = false;
    public static bool isLost = false;
    public GameObject gameControl;
    //public AudioSource clickFX;

    /*
     private void OnTriggerEnter(Collider other)
    {
        clickFX.Play();
        ScoreControl.score++;
        this.gameObject.SetActive(false);
    }
    */

    public void AddScore()
    {
        //ScoreControl.score+=2;
        if (!isClicked)
        {
            switch (ButtonColorControl.colorNumber)
            {
                case 1:
                    isLost = true;
                    gameControl.GetComponent<EndGame>().enabled = true;
                    break;
                case 2:
                    ScoreControl.score += 3;
                    break;
                case 3:
                    ScoreControl.score -= 3;
                    break;
                default:
                    break;
            }
            isClicked = true;
        }
        //clickFX.Play();
    }

}
