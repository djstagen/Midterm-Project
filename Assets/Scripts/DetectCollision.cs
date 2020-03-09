using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    ScoreManager scoreManager; 
    // Start is called before the first frame update
    void Start()
    {
        GameObject Object = GameObject.FindGameObjectWithTag("Player");

        scoreManager = Object.GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        GameObject Object = collision.gameObject;
        Debug.Log($"{gameObject.name} just hit {Object.name}.");
        //It will work with rigidBody
        Destroy(gameObject);
        scoreManager.IncrementScore();

        //This will not work with any tag.
       /* if (Object.CompareTag("Object"))
        {
            Destroy(gameObject);
            scoreManager.IncrementScore();
            //Destroy(other.gameObject);
        }*/

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
