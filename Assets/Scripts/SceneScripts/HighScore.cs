using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void ReturningToMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update () {
        ReturningToMenu ();
	}
}
