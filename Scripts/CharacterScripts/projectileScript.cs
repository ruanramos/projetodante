using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour {

    public Transform thisTransform;
    BoxCollider2D collider;
    bool isProjectile;
    
	void Start () {
        isProjectile = true;
        collider = GetComponent<BoxCollider2D>();
	}
	
	void Update () { //talvez por no lateupdate

        if (isProjectile){
            thisTransform.Translate(Vector3.right * 0.7f);
        }
	}

    private void OnCollisionEnter2D(Collision2D coll)
    {        
        if (coll.collider.tag == "Wall")        {
            isProjectile = false;
            collider.isTrigger = true;            
        }
    }

    private void OnTriggerEnter2D(Collider2D collisionTrig)
    {
        if (!isProjectile)
        {            
            if (collisionTrig.gameObject.tag == "Player")
            {
                collisionTrig.gameObject.GetComponent<CharacterActions>().spearOn = true;
                Destroy(this.gameObject);               
            }
        }
    }
}
