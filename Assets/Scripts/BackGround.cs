using UnityEngine;
public class BackGround : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
        if (gameObject.transform.position.y <= -10f)
        {
            Destroy(gameObject);
        }
    }
    
}
