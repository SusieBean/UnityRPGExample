using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] UnityEvent afterMoved;

    private Vector2 movementVector;

    bool canMove => !MapData.isEventPlaying;


    // Update is called once per frame
    void Update()
    {
        getPlayerMovement();
    }

    private void FixedUpdate()
    {
        setPlayerMovement();
    }

    void getPlayerMovement()
    {
        movementVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void setPlayerMovement()
    {
        rb.velocity = canMove ? movementVector.normalized * speed : Vector2.zero;
        if (rb.velocity.sqrMagnitude > 0f)
        {
            afterMoved.Invoke();
        }
    }
    
}
