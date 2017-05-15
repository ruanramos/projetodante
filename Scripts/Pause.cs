using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    bool paused;
    GameObject[] menu = new GameObject[5];
	
	void Start () {
        paused = false;
        menu = GameObject.FindGameObjectsWithTag("Menu");
        for(int i = 0; i < 5; i++) {
            menu[i].GetComponent<SpriteRenderer>().enabled = false;
        }
	}
	
	
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)) {
            paused = !paused;
            for (int i = 0; i < 5; i++) {
                menu[i].GetComponent<SpriteRenderer>().enabled = !menu[i].GetComponent<SpriteRenderer>().enabled;
            }
        }

        if(paused) {
            Time.timeScale = 0;
        }
        else {
            Time.timeScale = 1;
        }

	}
}
