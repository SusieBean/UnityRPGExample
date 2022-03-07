using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPhase : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string InteractText__TEST;

    public void interact()
    {
        Debug.Log("INTERACTING WITH PLAYER: " + InteractText__TEST);
    }

}
