using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public static int score;
    public GameObject scoreDisplay;
    public GameObject scoreEndDisplay;

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.GetComponent<Text>().text = "" + score;
        scoreEndDisplay.GetComponent<Text>().text = "" + score;
    }
}
