using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        string tag = col.gameObject.tag;
        //untuk menggelompokkan bird, enemy dan obstacle
        if (tag == "Bird" || tag == "Enemy" || tag == "Obstacle")
        {
            Destroy(col.gameObject);
        }
    }
}
