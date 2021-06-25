using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class OxygenTimer : MonoBehaviour
{
    [SerializeField]private float _time;
    private float _timeCurrent;
    private float _coeff=1;
    private Image _image;
    [SerializeField] private UnityEvent _tick;


    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
        _timeCurrent = _time;
    }

    // Update is called once per frame
    void Update()
    {
        Turn();
    }


    private void Turn()
    {
        _timeCurrent -= Time.deltaTime*_coeff;

        if (_timeCurrent <= 0)
        {
            _tick.Invoke();
        }
        _image.fillAmount = _timeCurrent / _time;

    }

    public void Coeff()
    {
        _coeff+=5;
    }
}
