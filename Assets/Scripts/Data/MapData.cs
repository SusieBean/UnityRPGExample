using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] AudioController audioController;
    [HideInInspector]public static MapData instance;

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
