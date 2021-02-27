using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] public float minX = 1f;
    [SerializeField] public float maxX = 14f;
    [SerializeField] public float screenWidthInUnits = 16f;

    //cached
    GameSession autoPlay;
    Ball ballPosition;


    // Start is called before the first frame update
    void Start()
    {
        autoPlay = FindObjectOfType<GameSession>();
        ballPosition = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
       //float mouseposinUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        //Vector2 paddlePos = new Vector2(mouseposinUnits, transform.position.y);
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);
        transform.position = paddlePos; 

    }

    private float GetXPos()
    {
        if(autoPlay.IsAutoPlayEnabled())
        {
            return ballPosition.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }

}
