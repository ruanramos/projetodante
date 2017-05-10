using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButton_Actions : MonoBehaviour {

    float speed;

	void Start () {
        this.speed = 1f;
	}

    void ButtonMovements () {
        if (this.transform.position == new Vector3(3, 3, -1) && Input.GetKeyDown(KeyCode.S))
            this.transform.position = new Vector3(3, 1.5f, -1);
        else if (this.transform.position == new Vector3(3, 1.5f, -1) && Input.GetKeyDown(KeyCode.W))
            this.transform.position = new Vector3(3, 3, -1);
        else if (this.transform.position == new Vector3(3, 1.5f, -1) && Input.GetKeyDown(KeyCode.S))
            this.transform.position = new Vector3(3, 0, -1);
        else if (this.transform.position == new Vector3(3, 0, -1) && Input.GetKeyDown(KeyCode.W))
            this.transform.position = new Vector3(3, 1.5f, -1);
        else if (this.transform.position == new Vector3(3, 0, -1) && Input.GetKeyDown(KeyCode.S))
            this.transform.position = new Vector3(3, -1.5f, -1);
        else if (this.transform.position == new Vector3(3, -1.5f, -1) && Input.GetKeyDown(KeyCode.W))
            this.transform.position = new Vector3(3, 0, -1);

    }

    void ButtonSelect () {
        if (this.transform.position == new Vector3(3, 3, -1) && Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Game");
        else if (this.transform.position == new Vector3(3, 1.5f, -1) && Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("HighScore");
        else if (this.transform.position == new Vector3(3, 0, -1) && Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Credits");
        else if (this.transform.position == new Vector3(3, -1.5f, -1) && Input.GetKeyDown(KeyCode.Space))
            Application.Quit();
            
    }

    void Update () {
        ButtonMovements ();
        ButtonSelect ();
	}
}
