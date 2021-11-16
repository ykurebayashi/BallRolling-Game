using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class theEndMenu : MonoBehaviour
{
    public GameObject[] stars;
    public GameObject gameManager;
    public int starsCaughtFinal;
    public Sprite caughtStar;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindWithTag("gameManagerTag"); //Pega o gameManager
        starsCaughtFinal = gameManager.GetComponent<gameManagerScript>().starsCaught; //Pega o numero de estrelas pega
        stars = GameObject.FindGameObjectsWithTag("endstar"); //Pega todos as estrelas do jogo
        for (int i = 0; i < starsCaughtFinal; i++) //Transforma os sprites de estrelas vazias em estrelas cheias
        {
            stars[i].GetComponent<Image>().sprite = caughtStar;
        }
    }

}
