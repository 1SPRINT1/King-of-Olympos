using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    private int scenka;
    [Header("Доступ к скриптам")]
    private PlayerBallController PBC;
    [Header("Панель проигрыша")]
    public GameObject GameOverPanel;
    [Header("Скины Игрока")]
    public GameObject Skin0;
    public GameObject Skin1;
    public GameObject Skin2;
    public GameObject Skin3;
    public GameObject Skin4;
    public GameObject Skin5;
    [Header("Монеты и лучший рекорд")]
    public float ScoreManager;
    public Text ScoreManagerText;

    public GameObject SpawnerM;
    public GameObject PlayerM;
    public GameObject RewardButton;
    public GameObject RewardButtonYES;
    public AudioSource AU;

    public GameObject PauseSystem;
    public bool isPause;

    public float Records;

    //public float timeStart = 10f;
    //public float timeEnd = 0f;
    private void Start()
    {
        PBC = FindObjectOfType<PlayerBallController>();
        Records = PlayerPrefs.GetFloat("RecordCount", Records);
    }

    private void Update()
    {
        if (GameOverPanel.activeSelf == true)
        {
            SpawnerM.SetActive(false);
            PlayerM.SetActive(false);
        }
        else
        {
            SpawnerM.SetActive(true);
            PlayerM.SetActive(true);
        }
        if (GameOverPanel.activeSelf == false)
        {
            ScoreManager = PBC.Score;
            ScoreManagerText.text = ScoreManager.ToString("#");
        }
        if (ScoreManager > Records)
        {
            Records = ScoreManager;
            PlayerPrefs.SetFloat("RecordCount", Records);
        }
        if (isPause == true)
        {
            Time.timeScale = 0;
        }
        if (isPause == false)
        {
            Time.timeScale = 1;
        }
        // if (RewardButton.activeSelf == true)
        //{

        // }
        //if (ScoreManager > YandexGame.savesData.BestScore)
       // {
       //     YandexGame.savesData.BestScore = ScoreManager;
       //     YandexGame.SaveProgress();
       // вставить сюда чтоб рекорд получать }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
        AU.Play();
    }
    public void Home()
    {
        SceneManager.LoadScene("Menu");
        AU.Play();
    }

    // Подписанный метод получения награды
    private float _empty;
}
