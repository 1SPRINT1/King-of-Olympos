using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{

    public void LoadSceneButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
