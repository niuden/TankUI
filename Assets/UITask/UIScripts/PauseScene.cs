using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScene : MonoBehaviour
{

	public void backgame()
	{
		SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) - 1);
	}

	public void exitgame()
	{
		SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) - 2);
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
