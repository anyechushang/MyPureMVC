using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginPanel : MonoBehaviour
{

    public InputField m_UserName;
    public InputField m_UserPassword;
    public Button m_Btn_Login;
    private LoginVO m_LoginVO;

    void Awake()
    {
        m_LoginVO = new LoginVO();
        AppFacade.Instance.RegisterMediator(new LoginPanelMediator(this));
    }

    public LoginVO GetLoginVO()
    {
        if(null == m_LoginVO)
        {
            m_LoginVO = new LoginVO();
        }
        m_LoginVO.username = m_UserName.text;
        m_LoginVO.password = m_UserPassword.text;
        return m_LoginVO;
    }

}
