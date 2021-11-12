using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    // Start is called before the first frame update
    float countDown = 10.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;

        if(countDown > 0){
            transform.position += Vector3.up * Time.deltaTime;
            transform.position += Vector3.right * Time.deltaTime;
        }
        else if (countDown > -10.0f){
            transform.position += Vector3.down * Time.deltaTime;
            transform.position += Vector3.left * Time.deltaTime;
        } // You don't want to move backwards too much!
            
            
    }
}
