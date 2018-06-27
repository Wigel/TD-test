using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public Text roundsText;

	// Use this for initialization
	void OnEnable () {
        roundsText.text = PlayerStats.Rounds.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Retry ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Debug.Log("Go to menu.");
    }
}
