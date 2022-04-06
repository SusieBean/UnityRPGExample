using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPhase : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string InteractText__TEST;
    [SerializeField] Color Colour___TEST;

    public void interact()
    {
        StartCoroutine(INTERACTION_DEBUG());
    }

    IEnumerator INTERACTION_DEBUG()
    {
        MapData.isEventPlaying = true;
        yield return Textbox.OpenTextbox(InteractText__TEST, Colour___TEST);
        MapData.isEventPlaying = false;
    }

}
