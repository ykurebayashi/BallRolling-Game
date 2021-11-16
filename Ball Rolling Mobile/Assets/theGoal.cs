using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theGoal : MonoBehaviour
{
    public GameObject theMenu;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        theMenu.SetActive(true); //Ativa a UI de endGame.
        Destroy(collision.gameObject);
    }
}
