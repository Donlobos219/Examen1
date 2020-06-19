using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicionDeAuto : MonoBehaviour
{
    public GameObject car;
    public float spawnRate = 2f;
    public float speed = 5f;
    public bool permitirAuto;
    // Start is called before the first frame update

    void Start()
    {
        permitirAuto = true;
        InvokeRepeating("auto", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
        {
            
        }

        
    }
    void auto()
    {
        Instantiate(car, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }

}
