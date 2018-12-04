using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Command;
using PureMVC.Interfaces;

public class StartUpCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        AppFacade.Instance.RegisterCommand(NotiConst.Login, () => new LoginCommand());
        ///Data应该再一个地方做初始化
        AppFacade.Instance.RegisterProxy(new LoginProxy());
    }
}
