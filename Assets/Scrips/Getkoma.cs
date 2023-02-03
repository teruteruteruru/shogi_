using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getkoma : MonoBehaviour
{
    public static void Get_koma(string winner ,player turn, name_koma[,] koma, int[] player1_motigoma, int[] player2_motigoma, int a, int b)
    {
        if (koma[a, b] == name_koma.gyoku)
        {
            if (turn == player.player1)
            {
                winner = "Winner:Player1";
            }
            else if (turn == player.player2)
            {
                winner = "Winner:Player2";
            }
        }
        else if (koma[a, b] == name_koma.hisha || koma[a, b] == name_koma.ryuu)
        {
            if (turn == player.player1)
            {
                player1_motigoma[0]++;
            }
            else if (turn == player.player2)
            {
                player2_motigoma[0]++;
            }

        }
        else if (koma[a, b] == name_koma.kaku || koma[a, b] == name_koma.uma)
        {
            if (turn == player.player1)
            {
                player1_motigoma[1]++;
            }
            else if (turn == player.player2)
            {
                player2_motigoma[1]++;
            }
        }
        else if (koma[a, b] == name_koma.kin)
        {
            if (turn == player.player1)
            {
                player1_motigoma[2]++;
            }
            else if (turn == player.player2)
            {
                player2_motigoma[2]++;
            }
        }
        else if (koma[a, b] == name_koma.gin || koma[a, b] == name_koma.nari_gin)
        {
            if (turn == player.player1)
            {
                player1_motigoma[3]++;
            }
            else if (turn == player.player2)
            {
                player2_motigoma[3]++;
            }
        }
        else if (koma[a, b] == name_koma.kei || koma[a, b] == name_koma.nari_kei)
        {
            if (turn == player.player1)
            {
                player1_motigoma[4]++;
            }
            else if (turn == player.player2)
            {
                player2_motigoma[4]++;
            }
        }
        else if (koma[a, b] == name_koma.kyou || koma[a, b] == name_koma.nari_kyou)
        {
            if (turn == player.player1)
            {
                player1_motigoma[5]++;
            }
            else if (turn == player.player2)
            {
                player2_motigoma[5]++;
            }
        }
        else if (koma[a, b] == name_koma.fu || koma[a, b] == name_koma.nari_fu)
        {
            if (turn == player.player1)
            {
                player1_motigoma[6]++;
            }
            else if (turn == player.player2)
            {
                player2_motigoma[6]++;
            }
        }
    }
}
