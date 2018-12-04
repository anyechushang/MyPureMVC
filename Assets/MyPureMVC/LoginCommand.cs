using PureMVC.Patterns.Command;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Interfaces;

public class LoginCommand : SimpleCommand
{

    public override void Execute(INotification notification)
    {
        LoginVO lv = notification.Body as LoginVO;
        LoginProxy temp = Facade.RetrieveProxy("LoginProxy") as LoginProxy;
        temp.Login(lv);
    }
}
