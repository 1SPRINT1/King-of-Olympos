using UnityEngine;
public class BallonManager : MonoBehaviour
{
    public GameObject Balon;
    public GameObject GameOverPanel;
    public bool isBallon = false;
    public GameObject isShield;
    public GameObject isEnd;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBallon == true)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                GameOverPanel.SetActive(true);
                Instantiate(isEnd, transform.position, Quaternion.identity);
            }
        }
        
    }
}
