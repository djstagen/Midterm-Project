using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //It will work with rigidBody

        Destroy(gameObject);
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
