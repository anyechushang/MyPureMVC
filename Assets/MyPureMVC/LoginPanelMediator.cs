using PureMVC.Patterns.Mediator;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Interfaces;

public class LoginPanelMediator : Mediator
{
    // The Mediator name
    public static new string NAME = "LoginPanelMediator";

    // Constructor
    public LoginPanelMediator(object viewComponent) : base(NAME, viewComponent)
    {
        LoginPanel.m_Btn_Login.onClick.AddListener(() => {
            AppFacade.Instance.ExecuteCommand(NotiConst.Login, LoginPanel.GetLoginVO());
        });
    }

    // // be sure that the mediator has some Observers created
    // in order to test removeMediator
    public override string[] ListNotificationInterests()
    {
        return new string[1] { LoginProxy.LOGIN_SUCCESS };
    }

    public override void HandleNotification(INotification notification)
    {
        switch(notification.Name)
        {
            case LoginProxy.LOGIN_SUCCESS:
                Debug.LogError(notification.Body as string);
                break;
        }
    }

    protected LoginPanel LoginPanel
    {
        get
        {
            return ViewComponent as LoginPanel;
        }
    } 
}
