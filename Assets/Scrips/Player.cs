using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

//�ǂ����̃v���C���[�̃^�[�����\�����Ă�N���X
public class Player : MonoBehaviour
{
    public player play_now;
    public Text player_name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject main_game = GameObject.Find("game");
        play_now = main_game.GetComponent<Shogi>().turn;
        if(play_now == player.player1)
        {
            player_name.text = "Player:Player1";
        }
        else if(play_now == player.player2)
        {
            player_name.text = "Player:Player2";
        }


    }
}
