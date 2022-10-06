using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Play()
    {
         SceneManager.LoadScene(3);
    }
    public void Tutorial()
    {
         SceneManager.LoadScene(1);
    }
    public void About()
    {
         SceneManager.LoadScene(2);
    }
}
