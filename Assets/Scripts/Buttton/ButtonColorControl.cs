using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorControl : MonoBehaviour
{
    private Color[] color = new Color[5];
    public static int colorNumber;
    public static Color currentColor;
    public Color previousColor;
    public GameObject button;
    private bool changeColor = false;
    private int delay;

    // Start is called before the first frame update
    void Start()
    {
        color[0] = Color.blue;
        color[1] = Color.black;
        color[2] = Color.green;
        color[3] = Color.red;
        color[4] = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        if (!changeColor)
        {
            changeColor = true;
            StartCoroutine(ChangeColor());
        }    
    }

    IEnumerator ChangeColor()
    {
        previousColor = currentColor;
        colorNumber = Random.Range(0, 5);
        currentColor = color[colorNumber];
        button.GetComponent<Image>().color = currentColor;
        ClickButton.isClicked = false;
        yield return new WaitForSeconds(2);
        changeColor = false;
    }

}
