using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float x = 0f;
    float y = 0f;
    public GameObject circle;
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawn()
    {
        x = Random.Range(-9, 9);
        y = Random.Range(-4, 4);
        Vector3 pos = new Vector3(x, y, 0);
        Instantiate(circle, pos, Quaternion.identity);
    }

}
