using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimSystem : MonoBehaviour
{
    public bool isStartAnim = false;
    public Animator AN;
    public Rigidbody2D RigiHEAD;
    public Rigidbody2D RigiSCORE;
    private void Update()
    {
        RigiHEAD.GetComponent<Rigidbody2D>();
        RigiSCORE.GetComponent<Rigidbody2D>();
    }
    public void StartAnim()
    {
        isStartAnim = true;
        AN.SetBool("isStart", isStartAnim);
        RigiHEAD.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
    public void scoreStartRigid()
    {
        RigiSCORE.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }

}
