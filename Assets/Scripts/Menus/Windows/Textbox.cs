using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Textbox : MonoBehaviour
{
    //under the assumption that we will only have one textbox. This will change
    [SerializeField] TMP_Text textDisplay;
    [SerializeField] GameObject clickNext;
    [SerializeField] float timePeriod;

    static Textbox instance = null;
    
    private void Awake()
    {
        instance = this;
        gameObject.SetActive(false);
    }

    public static Coroutine OpenTextbox(string text, Color textColour)
    {
        if (!instance.gameObject.activeSelf)
        {
            instance.gameObject.SetActive(true);
        }
        return instance.StartCoroutine(instance.textboxCoroutine(text, textColour));
    }

    IEnumerator textboxCoroutine(string text, Color textColour)
    {
        int TextLength = text.Length;
        string colourString = "<color=#" +  ColorUtility.ToHtmlStringRGB(textColour) + ">";
        for (int Count = 0; Count < TextLength + 1; Count++)
        {
            textDisplay.text = colourString + text.Substring(0, Count);
            yield return new WaitForSeconds(timePeriod);
        }
        clickNext.SetActive(true);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        clickNext.SetActive(false);
        gameObject.SetActive(false);
    }
}
