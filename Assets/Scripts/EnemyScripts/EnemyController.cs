using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody2D enemy;

    public Transform player;
    private float minDist = 0.5f;



    private int life;
    public float moveSpeed;

    // Use this for initialization
    void Start() {
        enemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Vector3 varLookat = enemy.transform.LookAt (player);
        //Vector2 direcaoPlayer = (varLookat);// , varLookat.y);

        float xPos = player.position.x - enemy.position.x;
        float yPos = player.position.y - enemy.position.y;
        float norm = Mathf.Sqrt(xPos * xPos + yPos * yPos);
        float xPosNormalized = xPos / norm;
        float yPosNormalized = yPos / norm;

        Vector3 position = new Vector3(xPosNormalized, yPosNormalized, 0);


        //enemy.transform.LookAt(player);

        if (Vector2.Distance(enemy.transform.position, player.position) > minDist)
        {
            enemy.transform.Translate(position * moveSpeed * Time.deltaTime);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            
        }
    }

    void die()
    {
        // funcao de morte
    }

}
