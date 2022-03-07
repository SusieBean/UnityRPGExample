using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Characters : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Rigidbody2D rb;
    [SerializeField] bool hasWalkingAnimation;
    [SerializeField] Animator anim;

    [SerializeField] UnityEvent directionSetEvent;

    public DIRECTION direction = DIRECTION.NONE;
    public float directionRadians => direction != DIRECTION.NONE ? ((float)direction / 8f - 0.5f)*Mathf.PI*2f : 0f;
    public Vector2 directionToVector2 => new Vector2(Mathf.Cos(directionRadians), Mathf.Sin(directionRadians));


    // Update is called once per frame
    void Update()
    {
        UpdateZPosition();
        if (shouldUpdateMovement)
        {
            setDirectionAndAnimator();
        }
    }

    void UpdateZPosition()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y * 0.01f);
    }

    bool shouldUpdateMovement => rb.velocity.magnitude > 0;


    public void setDirectionAndAnimator()
    {
        setDirection();
        if (hasWalkingAnimation)
        {
            passToAnimator();
        }
    }

    public void setDirection()
    {
        float NormalisedDirection = getNormalisedDirection();
        int directionToSet = Mathf.RoundToInt(NormalisedDirection * 8f) % 8;
        direction = (DIRECTION)directionToSet;
        directionSetEvent?.Invoke();
    }

    void passToAnimator()
    {
        anim.SetInteger("Direction", (int)direction);
    }



    float getNormalisedDirection()
    {
        return Mathf.Atan2(rb.velocity.y, rb.velocity.x) / (2 * Mathf.PI) + 0.5f;
    }


}
