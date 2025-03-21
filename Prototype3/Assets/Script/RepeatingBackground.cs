using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    private Vector3 startPos;
    private float offset;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        offset = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPos.x - offset)
        {
            transform.position = startPos;
        }
    }
}
