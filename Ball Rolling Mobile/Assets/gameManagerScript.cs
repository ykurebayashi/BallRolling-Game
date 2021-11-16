using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManagerScript : MonoBehaviour
{
    public GameObject cuber;
    private GameObject theBar;
    public GameObject theMenu;
    private GameObject tutorialMenu;
    public int starsCaught = 0;
    public int ballToThrow = 3;

    public Text ballsNumber;
    public Image ballImage;

    public Sprite[] ballSprite;


    void Start()
    {
        theBar = GameObject.FindWithTag("theBar"); //pegando a barra de altura minima
        tutorialMenu = GameObject.FindWithTag("startMenu"); //Pegando o meun inicual do jogo
        ballsNumber = GameObject.FindWithTag("ballNumber").GetComponent<Text>(); //Pegando o ballNumber no UI
        ballImage = GameObject.FindWithTag("uiBG").GetComponent<Image>(); //Pegando a imagem no UI
        ballsNumber.text = ballToThrow.ToString(); //Setando o numero de bolas no começo;
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
            if (p.y >= theBar.transform.position.y && theMenu.active == false && tutorialMenu.active == false && ballToThrow > 0)
            {
                Instantiate(cuber, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                ballToThrow -= 1;
                changeUIImage();
                ballsNumber.text = ballToThrow.ToString();
            }
        }
    }

    public void changeUIImage()
    {
        switch (ballToThrow)
        {
            case 2:
                ballImage.sprite = ballSprite[0];
                break;
            case 1:
                ballImage.sprite = ballSprite[1];
                break;
            case 0:
                ballImage.sprite = ballSprite[2];
                break;
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public  void    CloseTutorial()
    {
        tutorialMenu.SetActive(false);
    }
}

