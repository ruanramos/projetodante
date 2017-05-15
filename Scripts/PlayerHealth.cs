using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public Texture design, sangue;
    public int totalHealth = 4;
    public int currentHealth;
    int destroy = 1;
    AudioSource playerAudioSource;


    void Start() {
        currentHealth = totalHealth;   
        playerAudioSource = GetComponent<AudioSource>();
    }

    void Damage() {
        currentHealth--;

        switch(destroy) {
            case 1:
                Destroy(GameObject.Find("hp1"));
                break;
            case 2:
                Destroy(GameObject.Find("hp2"));
                break;
            case 3:
                Destroy(GameObject.Find("hp3"));
                break;
            default:
                Destroy(GameObject.Find("hp4"));
                break;
        }
        destroy++;
        
    }

    void Heal() {
        currentHealth++;
        if (currentHealth > totalHealth)
            currentHealth = totalHealth;
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Enemy") {
            Damage();
            playerAudioSource.Play();
        }
            
    }
}
  