using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartSceneScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
    }

    public void Option()
    {
        Debug.Log("设置页面开发中！");
    }

    public void Developer()
    {
        Debug.Log("开发者页面开发中！");
    }
    
    public void ExitGame()
    {
        // Application.Quit();
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) - 1);
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
