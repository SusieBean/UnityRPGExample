using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionCollider : MonoBehaviour
{
    [SerializeField] PlayerInteraction interaction;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        interaction.addPhase(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interaction.removePhase(collision);
    }
}
