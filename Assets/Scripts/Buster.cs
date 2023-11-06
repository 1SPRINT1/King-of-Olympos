using UnityEngine;
public class Buster : MonoBehaviour
{
    private float speed = 1f;

    private void Update()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
        if (gameObject.transform.position.y == 10f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Ballon"))
        {
            Destroy(gameObject);
        }
    }
}
