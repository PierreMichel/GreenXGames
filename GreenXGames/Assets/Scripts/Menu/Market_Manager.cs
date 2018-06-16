using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Market_Manager : MonoBehaviour
{
    public Animator Anim;

    void start ()
    {
        
    }

    public void OpenMarket()
    {
        Anim.enabled = true;
        Anim.SetBool("MarketUI", true);
    }

    public void CloseMarket()
    {
        Anim.SetBool("MarketUI", false);
    }
}
