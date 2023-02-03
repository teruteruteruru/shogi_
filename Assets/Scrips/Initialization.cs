using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//盤面の初期化をするクラス
public class Initialization : MonoBehaviour
{
    public static void Initialize(name_koma[,] koma, player[,] banmen)
    {
        //プレイヤー１

        for (int j = 0; j < 9; j++)
        {
            banmen[0, j] = player.player1;
            banmen[2, j] = player.player1;
        }
        banmen[1, 1] = player.player1;
        banmen[1, 7] = player.player1;



        //プレイヤー２


        for (int j = 0; j < 9; j++)
        {
            banmen[6, j] = player.player2;
            banmen[8, j] = player.player2;
        }
        banmen[7, 7] = player.player2;
        banmen[7, 1] = player.player2;
        //駒の初期化
        //gyoku:1 hisha:2 kaku:3 kin:4 gin:5 kei:6 kyou:7 fu:8 uma:9 ryuu:10

        //fu
        for (int i = 0; i < 9; i++)
        {
            koma[2, i] = name_koma.fu;
        }
        for (int k = 0; k < 9; k++)
        {
            koma[6, k] = name_koma.fu;
        }

        //gyoku
        koma[0, 4] = name_koma.gyoku;
        koma[8, 4] = name_koma.gyoku;

        //hisha
        koma[1, 1] = name_koma.hisha;
        koma[7, 7] = name_koma.hisha;

        //kaku
        koma[1, 7] = name_koma.kaku;
        koma[7, 1] = name_koma.kaku;

        //kin
        koma[0, 3] = name_koma.kin;
        koma[0, 5] = name_koma.kin;
        koma[8, 3] = name_koma.kin;
        koma[8, 5] = name_koma.kin;

        //gin
        koma[0, 2] = name_koma.gin;
        koma[0, 6] = name_koma.gin;
        koma[8, 2] = name_koma.gin;
        koma[8, 6] = name_koma.gin;

        //kei
        koma[0, 1] = name_koma.kei;
        koma[0, 7] = name_koma.kei;
        koma[8, 1] = name_koma.kei;
        koma[8, 7] = name_koma.kei;

        //kyou
        koma[0, 0] = name_koma.kyou;
        koma[0, 8] = name_koma.kyou;
        koma[8, 0] = name_koma.kyou;
        koma[8, 8] = name_koma.kyou;
    }
}
