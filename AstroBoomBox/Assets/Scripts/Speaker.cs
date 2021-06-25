using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Speaker : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _speedCurrent;
    private float _speedSet;
    private float _speedZero=0;
    [SerializeField]private float _force;
    [SerializeField] private GameObject _sonic;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _speedCurrent = _speedZero;

    }

    private void FixedUpdate()
    {
        _rb.AddRelativeForce(transform.up*_speedCurrent*Time.deltaTime*_force,ForceMode2D.Force);

    }

    public void SpeedSet()
    {
        _speedCurrent = _speedSet;
        _sonic.SetActive(true);
        _sonic.transform.localScale = new Vector3(_speedCurrent / 10, _speedCurrent / 10, _speedCurrent / 10);

    }

    public void SpeedZero()
    {
        _speedCurrent = _speedZero;
        _sonic.SetActive(false);
    }

    public void SetSpeetSet(float speed)
    {
        _speedSet = speed;
        SpeedSet();
    }
}
