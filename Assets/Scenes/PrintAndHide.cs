﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    // Start is called before the first frame update
    int i;
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("<"+gameObject.name+">:" + i);
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i >= 200 && i <= 250)
        {
            gameObject.SetActive(false);
            rend.enabled = false;
        }
        i++;
    }
}
