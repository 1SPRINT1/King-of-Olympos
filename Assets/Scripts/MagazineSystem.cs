using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class MagazineSystem : MonoBehaviour
{
    public PlayerBallController PBC;
    public SpawnManager SM;
    public GameObject Purchared1;
    public GameObject Purchared2;
    public GameObject Magazine;
    public bool isPurchared1;
    public bool isPurchared2;
    [Space(20)]
    [Header("Text")]
   // public Text textPurchared1;
  //  public Text textPurchased11;
  //  public Text textPurchared2;
  //  public Text textPurchared22;
    public GameObject objPurchased1;
    public GameObject objPurchased2;
    [Space(20)]
    [Header("Animators")]
    public Animator Purchared1Anim;
    public Animator Purchared2Anim;
    public Animator MagazineAnimator;
    public bool isGO = false;
    [Header("—чет на тек момент")]
    public float BestScoreCount;
 //   public Text BestTextCount;

    private void Update()
    {
        BestScoreCount = PlayerPrefs.GetFloat("RecordCount", BestScoreCount);
      //  BestTextCount.text = BestScoreCount.ToString("Best Score: #");
    }
    public void isNextPurchared2()
    {
        isPurchared2 = true;
        Purchared2Anim.SetBool("isNext", isPurchared2);
    }
    public void isEndNextPurchared2()
    {
        isPurchared2 = false;
        Purchared2.SetActive(false);
        Purchared2Anim.SetBool("isNext", isPurchared2);
    }
    public void isNextPurchared1()
    {
        isPurchared1 = true;
        Purchared1Anim.SetBool("isNext", isPurchared1);
    }
    public void isEndNextPurchared1()
    {
        isPurchared1 = false;
        Purchared1.SetActive(false);
        Purchared1Anim.SetBool("isNext", isPurchared1);
    }
    public void BuyPurchared1()
    {
        if (BestScoreCount >= 50f)
        {
            objPurchased1.SetActive(false);
            PBC.isBuyShield = true;
           // textPurchared1.text += "OK";
          //  textPurchased11.text += "OK";
            BestScoreCount -= 50f;
            PlayerPrefs.SetFloat("RecordCount", BestScoreCount);
        }
    }
    public void BuyPurchased2()
    {
        if (BestScoreCount >= 100f)
        {
            objPurchased2.SetActive(false);
            PBC.isX2Score = true;
          //  textPurchared2.text += "OK";
          //  textPurchared22.text += "OK";
            BestScoreCount -= 100f;
            PlayerPrefs.SetFloat("RecordCount", BestScoreCount);
        }
    }
    public void isShopExit()
    {
        Magazine.SetActive(false);
    }
    public void isShopAnimExit()
    {
        isGO = true;
        MagazineAnimator.SetBool("isGO", isGO);
    }
}
