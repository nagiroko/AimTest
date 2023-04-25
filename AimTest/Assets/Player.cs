using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Camera cam;
    Spawner spawns;
    public int score = 0;
    void Start()
    {
        cam = Camera.main;
        spawns= GameObject.FindGameObjectWithTag("Spawn").GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2d, Vector2.zero);
            if (hit.collider != null)
            {
                if(hit.collider.gameObject.tag == "Circle")
                {

                    score += 1;
                    Debug.Log(score);
                    Destroy(GameObject.FindGameObjectWithTag("Circle"));
                    spawns.spawn();
                }
            }
        }
    }
}
