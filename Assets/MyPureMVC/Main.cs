﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        AppFacade.Instance.StartUp();
    }
}
