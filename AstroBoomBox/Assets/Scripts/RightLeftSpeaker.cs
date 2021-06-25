using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLeftSpeaker : MonoBehaviour
{
    private AudioSource _music;
    private void Start()
    {
        _music = GetComponent<AudioSource>();
    }

    public void Left()
    {
        _music.panStereo = -1;
    }

    public void Right()
    {
        _music.panStereo = 1;
    }

    public void Zero()
    {
        _music.panStereo = 0;
    }
}
