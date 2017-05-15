using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

    public int   playerHP;
    GameObject jogador;
    public float finalHype;        //Pontuacao final do jogador quando ele morrer
    public float minimalHype; //Pontuacao que o jogador deve ter para não perder o jogo
    public float nextLevelHype; //Pontuacao que o jogador deve ter para passar de nível

    public string[] stageNames; //nome dos arquivos de cena de cada fase
    public int currentStage;

	// Use this for initialization
	void Start () {
        jogador = GameObject.FindWithTag("Player");
        
        

	}
	
	// Update is called once per frame
	void Update () {
        
        playerHP = jogador.GetComponent<PlayerHealth>().currentHealth;

        if (playerHP <= 0)
        {
            EndCombat();
        }
		
	}

    void EndCombat()
    {

        if(finalHype <= minimalHype)
        {
            SceneManager.LoadScene("GameOver");
        }

        else if (finalHype < nextLevelHype)
        {
            SceneManager.LoadScene(stageNames[currentStage]);
        }

        else if (finalHype >= nextLevelHype)
        {
            currentStage++;
            SceneManager.LoadScene(stageNames[currentStage]);
        }


    }
}
