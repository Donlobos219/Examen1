using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDerecha : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        Destroy(gameObject, 5f);
    }
}
