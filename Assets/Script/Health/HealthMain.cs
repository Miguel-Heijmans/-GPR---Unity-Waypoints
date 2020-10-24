using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthMain : MonoBehaviour
{
    protected int currentHealth = 1000;

    protected int enemCurrentHp = 100;

    protected int maxEnemHp = 100;

    protected int maxPlayerHP = 1000;
    //public Slider healthBarSlider;

    // public Text healthText;

    public int playerHp
    {
        get {return currentHealth;}
        set {currentHealth = value;}
    }

    public int playerMaxHp
    {
        get {return maxPlayerHP;}
        set {maxPlayerHP = value;}
    }

    public int enemyHp
    {
        get { return enemCurrentHp; }
        set { enemCurrentHp = value; }
    }

    public int enemyMaxHp
    {
        get { return maxEnemHp; }
        set { maxEnemHp = value; }
    }

    
    

    // Update is called once per frame
    void Update()
    {

        // healthBarSlider.maxValue = 100;
        // healthBarSlider.value = currentHealth;
        // healthText.text = currentHealth.ToString() + " / " + "100";

        // Debug.Log(healthBarSlider.value);
        
    }
}