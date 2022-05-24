using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercolision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<0)
        {
            transform.position = new Vector3(3.34f, 0.5f, 3.28f);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name=="deadwall")
        {
            transform.position = new Vector3 (3.34f, 0.5f, 3.28f);
        }
       
    }
}
