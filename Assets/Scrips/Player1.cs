using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


//どっちのプレイヤーのターンか表示してるクラス
public class Player1 : MonoBehaviour
{
    public player play_now;
    public Text player_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject main_game = GameObject.Find("game");
        play_now = main_game.GetComponent<Shogi>().turn;
        if (play_now == player.player1)
        {
            player_1.text = "<color=#ff0000>Player1</color>";
        }
        else if (play_now == player.player2)
        {
            player_1.text = "<color=#000000>Player1</color>";
        }


    }
}