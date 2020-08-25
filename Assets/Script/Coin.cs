using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Spinning();
        
    }
    public void Spinning()
    {
        transform.Rotate(15f * Time.deltaTime, 30f * Time.deltaTime, 45f * Time.deltaTime);


    }
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
