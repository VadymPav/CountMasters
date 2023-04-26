using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    [SerializeField] private MenuManager _menuManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("blue"))
        {
            _menuManager.IncreaseMoney();
            Destroy(gameObject);
        }
    }
}
