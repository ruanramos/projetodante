using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody2D enemy;

    public Transform player;
    private float minDist= 2;
    private float maxDist = 200;


    private int life;
    public float moveSpeed;

    // Use this for initialization
	void Start () {
        enemy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		
		//Vector3 varLookat = enemy.transform.LookAt (player);
		//Vector2 direcaoPlayer = (varLookat);// , varLookat.y);

        if (Vector2.Distance(enemy.transform.position, player.position) > minDist)
        {
			
			enemy.transform.Translate(moveSpeed * Time.deltaTime , moveSpeed * Time.deltaTime , 0);
        }

        if (Vector2.Distance(enemy.transform.position, player.position) <= minDist)
        {
            attack();
        }
    }

	void LateUpdate (){
		//enemy.transform.position = new Vector3 (enemy.transform.position.x, enemy.transform.position.y, 0);

	}

    void attack ()
    {
        // funcao de ataque se existir
    }

    void die ()
    {
        // funcao de morte
    }
}
