using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeateBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatLength;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatLength = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < startPos.z - repeatLength)
        {
            transform.position = startPos;
        }
    }
}
