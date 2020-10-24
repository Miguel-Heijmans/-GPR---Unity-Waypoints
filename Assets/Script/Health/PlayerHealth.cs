// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerHealth : MonoBehaviour
// {
    
//     public void TakeDamage()
//     {
//         print("I'm here");
//         Health -= 10;
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : HealthMain
{
    public Slider healthBarSlider;

    public Text healthText;

    bool damage;

    // Update is called once per frame
    void Update()
    {

        // if (playerHp == 0)
        // {
        //     SceneManager.LoadScene(sceneBuildIndex: 1);
        // }

        healthBarSlider.maxValue = playerMaxHp;
        healthBarSlider.value = playerHp;
        healthText.text = healthBarSlider.value.ToString() + " / " + healthBarSlider.maxValue.ToString();
        
            
        
    }

        public void TakeDamage()
            {
                print("I'm here");
                playerHp -= 1;
            }

     //HealthMain healthMain = new HealthMain();

            
   
}