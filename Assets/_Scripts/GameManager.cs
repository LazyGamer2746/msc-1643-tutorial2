using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int winningScore;
    public TMP_Text player1text;
    public TMP_Text player2text;

    private static int player1score;
    private static int player2score;
    // Start is called before the first frame update
    void Start()
    {
        player1score = 0;
        player2score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        player1text.text = player1score.ToString();
        player2text.text = player2score.ToString();

    }

    public static void AddScore(int player)
    {
        if (player == 1)
        {
            player1score++;
        }
        else if (player == 2)
        {
            player2score++;
        }
    }
    
}