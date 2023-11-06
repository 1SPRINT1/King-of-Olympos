using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBallController : MonoBehaviour
{
    public float speed;

    public Joystick joystick;
    public GameObject Joy;
    public GameObject Joy1;
    public GameObject StartMagazine;
    public GameObject GameOverMenu;
    private Rigidbody2D rg2d;
    private Vector2 moveVelocity;

    public Text ScoreTXT;
    public float Score;
    public float Records;

    private PlayerManager PM;
    public BallonManager BM;

    [Header("Emotions")]
    public GameObject[] effects;
    public GameObject[] effectsCrash;
    public Vector2 _whereToSpawn;
    [Space(30)]
    [Header("ComboPlashka")]
    public GameObject ComboImage;
    public GameObject ComboEffect;
    public GameObject ComboEffect2;
    public Animator ComboAnimator;
    [SerializeField] private int comboX;
    public Text comboText;
    public bool isCombo;
    [SerializeField] private float BTWTimeCombo;
    public float startTimeBTWCombo = 20f;
    [Space(40)]
    [Header("Buying")]
    public bool isX2Score;
    public bool isBuyShield;
    private void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        PM = FindFirstObjectByType<PlayerManager>();
        BTWTimeCombo = startTimeBTWCombo;
    }
    private void Update()
    {
        if (isBuyShield == true)
        {
            BM.isShield.SetActive(true);
        }
        else
        {
            BM.isShield.SetActive(false);
        }
        _whereToSpawn = new Vector2(Random.Range(-0.1f, 0.4f), -3.95f);
        ScoreTXT.text = Score.ToString("#");
        if (Score == 0)
        {
            ScoreTXT.text = "0";
        }
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);
        moveVelocity = movement.normalized * speed;
         comboText.text = comboX.ToString("Combo X#");

        BTWTimeCombo -= Time.deltaTime;
        ComboAnimator.SetBool("isCombo", isCombo);
        if (isCombo == true && BTWTimeCombo > 7f)
        {
            ComboEffect.SetActive(true);
            ComboImage.SetActive(true);
            ComboEffect2.SetActive(true);
            comboText.text = comboX.ToString("Combo X#");
        }
        if (BTWTimeCombo <= 7f && isCombo == true)
        {
            ComboEffect.SetActive(false);
            ComboImage.SetActive(false);
            ComboEffect2.SetActive(false);
            isCombo = false;
            comboX = 0;
        }


        if (StartMagazine.activeSelf == true || GameOverMenu.activeSelf == true)
        {
            Joy.SetActive(false);
            joystick.enabled = false;
        }
        else
        {
            Joy.SetActive(true);
            joystick.enabled = true;
            Joy1.SetActive(true);
        }
        
    }
    private void FixedUpdate()
    {
        rg2d.MovePosition(rg2d.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            BTWTimeCombo = startTimeBTWCombo;
            isCombo = true;
            comboX += 1;
            Score += 0.5f;
            if (isX2Score == true)
            {
                Score += 1f;
            }
            ScoreTXT.text = Score.ToString("#");
            Instantiate(effectsCrash[Random.Range(0, effectsCrash.Length)],transform.localPosition, Quaternion.identity);
          //  Instantiate(effects[Random.Range(0, effects.Length)],_whereToSpawn,Quaternion.identity);
        }
    }
}
