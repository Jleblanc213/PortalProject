using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] AudioClip _startingSong;
    [SerializeField] Text _highScoreTextView;
    void Start()
    {
        if (_startingSong != null)
        {
            AudioManager.Instance.PlaySong(_startingSong);
            Debug.Log("Audio is playing");
        }

        int highScore = PlayerPrefs.GetInt("HighScore");
        _highScoreTextView.text = highScore.ToString();
        
       
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
