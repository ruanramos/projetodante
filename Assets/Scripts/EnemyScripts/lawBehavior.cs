using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lawBehavior : MonoBehaviour {

	public float speedx = 4, speedy = 4, changer = 0;

    bool forward = true, up = true, change = false;
    int trocou = 0;
	public float xmax = 8, xmin = -8, ymax = 4, ymin = -4;

    void Start() {

    }

    
    void Update() {
        GetComponent < Rigidbody2D>().WakeUp();
       
            if (forward)
                transform.Translate(speedx * Time.deltaTime, 0, 0);
            else
                transform.Translate(-speedx * Time.deltaTime, 0, 0);

            if (up)
                transform.Translate(0, speedy * Time.deltaTime, 0);
            else
                transform.Translate(0, -speedy * Time.deltaTime, 0);

            if (transform.position.x > xmax)
                forward = false;
            if (transform.position.x < xmin)
                forward = true;

            if (transform.position.y > ymax)
                up = false;
            if (transform.position.y < ymin)
                up = true;
        
        if(changer == 500 || changer == 1500 || changer == 2500) {
            speedx++;
            speedy++; 
        }

        if (changer == 1000 || changer == 2000)
            change = true;

        if (change) {
            if (trocou == 0) {
                speedx = 4.5f;
                speedy += 4;
                trocou++;
            }
            else { 
                speedx = speedy;
                speedy = 5.5f;
                }

            change = false;
        }

        changer++;
  
        

    }

}
