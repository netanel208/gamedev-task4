using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.position = GameObject.Find("Main Camera").transform.position + (new Vector3(0, 5, 0));
    }
}
