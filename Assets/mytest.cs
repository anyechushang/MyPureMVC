using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Facade;

public class mytest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        FacadeTest temp = new FacadeTest();
        temp.TestRegisterCommandAndSendNotification();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
