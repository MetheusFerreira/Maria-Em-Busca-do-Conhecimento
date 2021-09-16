using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource audio;

    public AudioClip click;
    
    public static SFXManager sfx;
    void Awake()
    {
        if(sfx == null)
        {
            sfx = this;
            DontDestroyOnLoad(sfx);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
