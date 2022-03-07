using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] BoxCollider2D interactionBox;
    [SerializeField] Characters character;

    [SerializeField] float xOffsetMax;
    [SerializeField] float yOffsetMax;

    List<NPCPhase> phases = new List<NPCPhase>();
    NPCPhase phaseToInteractWith => phases.Count > 0 ? phases[0] : null;

    private void Update()
    {
        if (Input.GetButton("Interact"))
        {
            interact();
        }
    }

    void interact()
    {
        if (phaseToInteractWith != null)
        {
            phaseToInteractWith.interact();
        }
        else
        {
            Debug.Log("Nothing to interact with");
        }
    }



    public void setBoxPosition()
    {
        Vector2 directionVector = character.directionToVector2;
        directionVector.x *= xOffsetMax;
        directionVector.y *= yOffsetMax;

        interactionBox.transform.localPosition = directionVector;
    }
   
    public void addPhase(Collider2D collision)
    {
        NPCPhase phase = collision.GetComponentInParent<NPCPhase>();
        if (phase != null)
        {
            phases.Add(phase);
            Debug.Log("ADD PHASE");
        }
        
    }

    public void removePhase(Collider2D collision)
    {
        NPCPhase phase = collision.GetComponentInParent<NPCPhase>();
        if (phase != null)
        {
            phases.Remove(phase);
            Debug.Log("REMOVE PHASE");
        }
    }

}
