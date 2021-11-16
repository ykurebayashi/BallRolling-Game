using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject particle;
    public GameObject sound;
    void Start()
    {
        gameManager = GameObject.FindWithTag("gameManagerTag"); //Pega o gameManager
        Destroy(gameObject, 8f);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("star"))
        {
            gameManager.GetComponent<gameManagerScript>().starsCaught += 1; //Pega o script do gameManager e adiciona uma estrela no gameManager
            Destroy(other.gameObject); //Destroi a estrela pra não ser pega novamente
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "obstacle" || coll.gameObject.tag == "Player")
        {
            var theSound = Instantiate(sound, new Vector3(transform.position.x, transform.position.y, -5), Quaternion.identity);
            Destroy(theSound, 1);
            var theParticle = Instantiate(particle, new Vector3(transform.position.x, transform.position.y, -5), Quaternion.identity);
            Destroy(theParticle, 2);
        }
    }
}
