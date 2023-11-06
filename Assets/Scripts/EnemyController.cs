using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float speed = 1f;
    private AudioSource AU;
    private void Start()
    {
        AU = GetComponent<AudioSource>();
    }
    private void Update()
    {
        transform.Translate(0f,-speed * Time.deltaTime,0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyBarrier"))
        {
            AU.Play();
            Destroy(gameObject,1f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Shield"))
        {
            Destroy(collision.gameObject);
        }
    }
}
