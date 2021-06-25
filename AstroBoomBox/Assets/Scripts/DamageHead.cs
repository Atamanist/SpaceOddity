using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DamageHead : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speedCurrent;
    private int _damage=0;
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private UnityEvent _die;
    [SerializeField] private UnityEvent _oxygenLose;



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (!collision.gameObject.CompareTag("Wall"))
        {
            _damage++;
            _oxygenLose.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Flame"))
        {
            _die.Invoke();
        }

    }

    private void FixedUpdate()
    {
        if(_damage>0)
        {
            if (CompareTag("Head"))
            {
                _rb.AddRelativeForce(-1*transform.up * _speedCurrent * Time.deltaTime, ForceMode2D.Force);

            }
            if (CompareTag("armR"))
            {
                _rb.AddRelativeForce(-1 * transform.right * _speedCurrent * Time.deltaTime, ForceMode2D.Force);

            }
            if (CompareTag("armL"))
            {
                _rb.AddRelativeForce(transform.right * _speedCurrent * Time.deltaTime, ForceMode2D.Force);

            }
            _particle.gameObject.SetActive(true);
        }
        if(_damage>=2)
        {
            _die.Invoke();
        }
    }
}
