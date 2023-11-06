using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMagaazineAnim : MonoBehaviour
{
    public MagazineSystem MS;

    public void isEndNextPurchared2()
    {
        MS.isPurchared2 = false;
        MS.Purchared2.SetActive(false);
        MS.Purchared2Anim.SetBool("isNext", MS.isPurchared2);
    }
    public void isEndNextPurchared1()
    {
        MS.isPurchared1 = false;
        MS.Purchared1.SetActive(false);
        MS.Purchared1Anim.SetBool("isNext", MS.isPurchared1);
    }
}
