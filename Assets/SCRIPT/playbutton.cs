using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
     public void playGame()
    {
        SceneManager.LoadScene("Utama");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
