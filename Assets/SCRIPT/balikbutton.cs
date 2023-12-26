using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class balikbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitGame()
    {
        SceneManager.LoadScene("Background");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
