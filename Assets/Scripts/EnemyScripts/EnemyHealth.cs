using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int totalHealth; 
    public int currentHealth;

    void Start() {
        currentHealth = totalHealth; // Começa dando a vida específica total do monstro para a vida atual
    }

    public void Damage() { //Função chamada quando a hitbox for atingida
        currentHealth--; // Supondo que o personagem bata 1. Facilmente alterável.
        if (currentHealth <= 0)  // Se a vida chega em 0, deleta ele da cena
            Destroy(gameObject);
    }


    public void Die()
    {

    }
}
