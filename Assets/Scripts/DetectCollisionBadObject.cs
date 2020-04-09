using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisionBadObject : MonoBehaviour
{
    ScoreManager scoreManagerSanity; 
    // Start is called before the first frame update
    void Start()
    {
        GameObject Object = GameObject.FindGameObjectWithTag("Player");

        scoreManagerSanity = Object.GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject Object = other.gameObject;
        Debug.Log($"{gameObject.name} just hit {Object.name}.");
        //It will work with rigidBody
        Destroy(gameObject);
        scoreManagerSanity.DecrementScore();

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
