using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{

    [SerializeField] private Transform _player;
    [SerializeField] private Transform _module;
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        _text.text = Vector2.Distance(_player.position, _module.position).ToString();
    }

}
