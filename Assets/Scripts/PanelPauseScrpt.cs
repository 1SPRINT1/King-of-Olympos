using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPauseScrpt : MonoBehaviour
{
    [SerializeField] private Vector3 _startTransform;
    public GameObject PausePanel;
    public Rigidbody2D PauseRigid;
    public PlayerManager PM;
    private void Start()
    {
        _startTransform = transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PausePanel"))
        {
            transform.position = _startTransform;
            PausePanel.SetActive(false);
        }
    }
    
    public void PausePanelTrue()
    {
        PM.isPause = true;
    }
    public void PausePanelFALSE()
    {
        PM.isPause = false;
        PausePanel.SetActive(false);
    }
}
