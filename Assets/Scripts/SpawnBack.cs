using UnityEngine;
public class SpawnBack : MonoBehaviour
{
    [SerializeField] private GameObject[] _object; // ������� ������� ������ � �������
    [HideInInspector] private float RandX; // ��������� ������������ �� � �������
    [SerializeField] float RandX1; // ��������� ������������ �� � ������� ��� ����� 1
    [SerializeField] float RandX2; // ��������� ������������ �� � ������� ��� ����� 2
    [HideInInspector] private float YPos; // ������������ �� Y �������
    [SerializeField] float YPos1;
    [SerializeField] float YPos2;
    [HideInInspector] private Vector3 _whereToSpawn; // ��� ��������(���� � ��� �� ������� ��� ��� �����)
    public float spawnRate = 2f; // ��� � ����� ����� ��������
    [SerializeField] float nextSpawn = 0.0f; // ���������� ������ ����� ����� ��������� �����
    //[SerializeField] bool isGameStarted = false;

    private void Start()
    {
   //     StartCoroutine(StartDelay());
    }

    private void Update()
    {
        if (Time.time > nextSpawn)// && isGameStarted == true)// && StarTime < 10f)
        {
            nextSpawn = Time.time + 7f;
            RandX = Random.Range(RandX1, RandX2);
            YPos = Random.Range(YPos1, YPos2);
            _whereToSpawn = new Vector3(RandX, YPos);
            Instantiate(_object[Random.Range(0, _object.Length)], _whereToSpawn, Quaternion.identity);
        }
    }
   // private IEnumerator StartDelay()
  //  {
   //     yield return new WaitForSeconds(3);
//
   //     isGameStarted = true;
  //  }
}
