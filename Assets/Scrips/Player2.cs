using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;



//どっちのプレイヤーのターンか表示してるクラス
public class Player2 : MonoBehaviour
{
    public player play_now;
    public Text player_2;
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
            player_2.text = "<color=#000000>Player2</color>";
        }
        else if (play_now == player.player2)
        {
            player_2.text = "<color=#ff0000>Player2</color>";
        }


    }
}