using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject liveScore;
    public GameObject endScreen;

    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(2);
        liveScore.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        //fadeOut.SetActive(true);
        //yield return new WaitForSeconds(2);
        //SceneManager.LoadScene(0);
    }

}
