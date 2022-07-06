using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{

    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedGainPerSecond = 0.2f;

    [SerializeField] private float turnSpeed = 200f;

    private int steerValue;

    // Update is called once per frame
    /* 
        the update loop will be called more on faster devices
        Time.deltaTime makes it frame rate independent
     */
    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;
        
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Obstacle")){
            SceneManager.LoadScene("Scene_MainMenu");
        } 
    }

    public void SetSteer(int value){
        steerValue = value;
    }
}
