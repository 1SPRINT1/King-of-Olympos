using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public float RecordCount;
    public static SaveSystem instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        //RecordCount = PlayerPrefs.GetFloat("Record", RecordCount);
        RecordCount = PlayerPrefs.GetFloat("RecordCount", RecordCount);
    }
    private void Start()
    {
    }
}
