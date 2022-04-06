using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] AudioController audioController;
    [HideInInspector]public static MapData instance;
    /// <summary>
    /// TODO: INSTEAD OF USING A FLAG, USE SOME OTHER WAY TO CONTROL THE SYSTEM
    /// </summary>
    bool _isEventPlaying = false;
    public static bool isEventPlaying { get => instance._isEventPlaying; set { instance._isEventPlaying = value; }}

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        instance = this;

        if (AudioController.instance == null)
        {
            Instantiate(audioController);
        }
    }


}
