using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealt : MonoBehaviour
{
    public int currentHealth;
    public int maxhealth;

    public TMP_Text healthText;
    public Animator healthTextAnim;

    private void Start()
    {
        healthText.text = "HP: " + currentHealth + " / " + maxhealth;
    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        healthText.text = "HP: " + currentHealth + " / " + maxhealth;
        healthTextAnim.Play("TextUpdate");

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
