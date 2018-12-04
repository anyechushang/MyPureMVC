using PureMVC.Patterns.Proxy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginProxy : Proxy
{
    public const string LOGIN_SUCCESS = "loginSuccess"; 
    public LoginProxy():base("LoginProxy",new LoginVO())
    {

    }

    public void Login(LoginVO tryLogin)
    {
        LoginVO.username = tryLogin.username;
        LoginVO.password = tryLogin.password;
        Debug.LogError(LoginVO.username + "--" + LoginVO.password);
        //发送消息，这里直接返回true
        OnResult(true);
    }

    public void OnResult(bool istrue)
    {
        if(istrue)
        {
            SendNotification(LOGIN_SUCCESS, "123", null);
        }
        else
        {

        }
    }

    public LoginVO LoginVO
    {
        get
        {
            return Data as LoginVO;
        }
    }
}
