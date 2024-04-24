using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Met : MonoBehaviour
{
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.FindWithTag("Player");
    }

    private void OnMouseDown()
    {
        _player.GetComponent<MobContr>().MoveTo(transform);
    }
}
