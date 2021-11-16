using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("deu");
        Destroy(gameObject);
    }
}
