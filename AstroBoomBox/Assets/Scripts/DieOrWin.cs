using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DieOrWin : MonoBehaviour
{
    [SerializeField] private GameObject _die;
    [SerializeField] private GameObject _win;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _win.SetActive(true);
        }

    }

    public void Die()
    {
        _die.SetActive(true);
    }
}
