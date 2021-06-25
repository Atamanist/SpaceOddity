using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{

    private float _size;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _minSpeed, _maxSpeed;


    private Rigidbody2D _asteroid;

    // Start is called before the first frame update
    void Start()
    {
        _size = Random.Range(0.5f, 1.5f);

        _asteroid = GetComponent<Rigidbody2D>();

        _asteroid.angularVelocity = _rotationSpeed * Random.Range(-1, 1) / _size;
        _asteroid.transform.localScale *= _size;
        _asteroid.velocity = new Vector2(Random.Range(_minSpeed,_maxSpeed)*Random.Range(-1,1), Random.Range(_minSpeed, _maxSpeed) * Random.Range(-1, 1)) / _size;

    }

}
