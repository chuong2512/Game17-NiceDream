using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class SettingApp : MonoBehaviour
{
    public void Hide()
    {
        gameObject.SetActive(false);
    }
    
    public void OnClickRateUs()
    {
        Application.OpenURL("market://details?id=" + Application.identifier);
    }

    public void OnClickPrivacy()
    {
        Application.OpenURL("");
    }

}