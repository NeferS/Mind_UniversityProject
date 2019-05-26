﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInteraction : MonoBehaviour
{
    [SerializeField] private string text;
    [SerializeField] private Text target;

    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<CharacterController>() && text != null)
        {
            target.enabled = true;
            target.text = text;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<CharacterController>())
        {
            target.enabled = false;
            target.text = "";
        }
    }
}