using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCamera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject player;
    Vector2 positionOnScreen;
   

    // Update is called once per frame
    private void Update()
    {
        UpdatePosition();
        MakePixelPerfect();
    }

    void UpdatePosition()
    {
        positionOnScreen = new Vector2(player.transform.position.x, player.transform.position.y);
    }

    void MakePixelPerfect()
    {
        float perfectX = Mathf.Round(positionOnScreen.x * 16f) / 16f;
        float perfectY = Mathf.Round(positionOnScreen.y * 16f) / 16f;
        transform.position = new Vector3(perfectX, perfectY, -10f);
    }
}
