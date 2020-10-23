using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health;
    public float EnemyHealth;
    public void TakeDamage()
    {
        print("I'm here");
        Health -= 10;
    }
}
