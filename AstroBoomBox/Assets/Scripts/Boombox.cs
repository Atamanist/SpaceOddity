using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Boombox : MonoBehaviour
{
    private float _speedCurrent;
    private float _speedSet;
    private bool _play = false;
    [SerializeField]private UnityEvent<float> _setSpeed;
    private AudioSource _music;
    [SerializeField] private AudioSource _breath;
    [SerializeField] private Speaker _left, _right;



    private void Start()
    {
        _music = GetComponent<AudioSource>();
    }

    public void Volume(float volume)
    {
        _speedCurrent = volume * 10;
        _speedSet = _speedCurrent;
        if(_play==true)
        {
            _setSpeed.Invoke(_speedCurrent);
            _music.volume = volume;
        }
    }

    public void PlayPause()
    {
        if(_play==false)
        {
            _play = !_play;
            _speedCurrent = _speedSet;
            _setSpeed.Invoke(_speedCurrent);
            _music.Play();
            _breath.Pause();
        }
        else
        {
            _play = !_play;
            _speedSet = _speedCurrent;
            _speedCurrent = 0;
            _setSpeed.Invoke(_speedCurrent);
            _music.Pause();
            _breath.Play();
        }
    }

}
