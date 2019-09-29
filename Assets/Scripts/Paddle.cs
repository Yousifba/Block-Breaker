using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;


    // Cached refrences
    bool autoPlay;
    Ball ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = FindObjectOfType<Ball>();
        autoPlay = FindObjectOfType<GameSession>().getAutoPlay();
    }

    // Update is called once per frame
    void Update()
    {       
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(getXPos(), minX, maxX);
        transform.position = paddlePos;
    }

    private float getXPos()
    {
        if (autoPlay)
        {
            return ball.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }
}
