using UnityEngine;
using UnityEngine.SceneManagement;

public class exitbutton : MonoBehaviour
{
    public void ExitGame()
    {
        SceneManager.LoadScene("Utama");
    }
}
