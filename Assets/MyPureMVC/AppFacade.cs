using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Facade;

public class AppFacade : Facade
{
    private static AppFacade _instance;
    public AppFacade(string key) : base(key)
    {

    }

    public static AppFacade Instance
    {
        get
        {
            if (null == _instance)
            {
                _instance = new AppFacade("AppFacade");
            }
            return _instance;
        }
    }

    protected override void InitializeFacade()
    {
        base.InitializeFacade();
        RegisterCommand(NotiConst.START_UP, () => new StartUpCommand());
    }

    /// <summary>
    /// 启动框架
    /// </summary>
    public void StartUp()
    {
        ExecuteCommand(NotiConst.START_UP);
        RemoveCommand(NotiConst.START_UP);
    }
}
