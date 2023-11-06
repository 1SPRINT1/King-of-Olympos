using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public Text BestScoreText;
    public Text BestScoreTextShadow;
    public float BestScore;
  //  private void OnEnable()
  //  {
  //      YandexGame.GetDataEvent += GetLoad;
  //  }

    // Отписываемся от события открытия рекламы в OnDisable
  //  private void OnDisable()
   // {
   //     YandexGame.GetDataEvent -= GetLoad;
   // }

  //  private void Awake()
  //  {
   //     if (YandexGame.SDKEnabled == true)
   //     {
   //         GetLoad();
    //    }
   // }
    private void Update()
    {
        // здесь сделать синхронизацию текста и рекорда
        BestScore = PlayerPrefs.GetFloat("RecordCount", BestScore);
        BestScoreText.text = BestScore.ToString("#");
        BestScoreTextShadow.text = BestScore.ToString("#");
    }
    public void StartGameButton()
    {
        SceneManager.LoadScene("Game");
    }
  //  public void GetLoad()
  //  {
  //      BestScore = YandexGame.savesData.BestScore;
  //  }
}
