using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=transform.position+ new Vector3(10f,0,0);
    }
}
