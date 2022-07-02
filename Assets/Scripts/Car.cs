using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedGainPerSecond = 0.2f;

    // Update is called once per frame
    void Update()
    {
        /* 
            the update loop will be called more on faster devices
            Time.deltaTime makes it frame rate independent
        */
        speed += speedGainPerSecond * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
