using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerHealth;

public class Enemy : HealthMain
{

    
    //private Quaternion rotate;
    [SerializeField] private GameObject test;
    private Vector3 testLocation;

    public Slider healthBarSlider;
    public Text healthText;

    void Awake()
    {
        //rotate = transform.rotation;
        test = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update()
    {
        //transform.rotation = rotate;
        testLocation = test.transform.position;
        this.gameObject.transform.position = new Vector3(testLocation.x, transform.position.y, testLocation.z + 1.5f);


        // if (ene == 0)
        // {
        //     SceneManager.LoadScene(sceneBuildIndex: 1);
        // }

        healthBarSlider.maxValue = enemyMaxHp;
        healthBarSlider.value = enemyHp;
        healthText.text = healthBarSlider.value.ToString() + " / " + healthBarSlider.maxValue.ToString();

       

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            enemyHp -= 10;
            // Debug.Log(enemyHp);
            // Debug.Log("hp");
            // Debug.Log(healthBarSlider.value);
            // Debug.Log("slider");

        }
    }
}


