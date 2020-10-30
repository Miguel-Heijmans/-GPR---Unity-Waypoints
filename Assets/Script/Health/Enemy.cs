using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerHealth;

public class Enemy : HealthMain
{


    public Slider healthBarSlider;
    public Text healthText;

   

    void Update()
    {
        

        healthBarSlider.maxValue = enemyMaxHp;
        healthBarSlider.value = enemyHp;
        healthText.text = healthBarSlider.value.ToString() + " / " + healthBarSlider.maxValue.ToString();

        if (enemyHp <= 0)
        {
            Destroy(gameObject);
        }

        // if (Input.GetKeyDown(KeyCode.Alpha5))
        // {
        //     enemyHp -= 10;
        //     // Debug.Log(enemyHp);
        //     // Debug.Log("hp");
        //     // Debug.Log(healthBarSlider.value);
        //     // Debug.Log("slider");

        // }
    }
}


