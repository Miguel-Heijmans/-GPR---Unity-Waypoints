using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] private GameObject test;
    private Vector3 testLocation;

    void Awake()
    {
        test = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update()
    {
        testLocation = test.transform.position;
        this.gameObject.transform.position = new Vector3(testLocation.x, transform.position.y, testLocation.z + 1.5f);
    }
}


