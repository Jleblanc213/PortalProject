using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level01Controller : MonoBehaviour
{
    

        
    
     private void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    
    




    int _currentScore;
    private void Update()
    {
       

        //Exit Level
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitLevel();
        }
    }

    // Update is called once per frame
    public void ExitLevel()
    {
        int highScore = PlayerPrefs.GetInt("HighScore");
        if (_currentScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", _currentScore);
            Debug.Log("New high score" + _currentScore);
        }

        SceneManager.LoadScene("MainMenu");
    }
   
    

}
