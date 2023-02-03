using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//駒を配置するクラス、配列を読み込んで駒を配置してる
public class Arrangement : Instantiation
{
    public static GameObject gyoku;
    public static GameObject hisha;
    public static GameObject kaku;
    public static GameObject kin;
    public static GameObject gin;
    public static GameObject kei;
    public static GameObject kyou;
    public static GameObject fu;
    public static GameObject ryuu;
    public static GameObject uma;
    public static GameObject nari_gin;
    public static GameObject nari_kyou;
    public static GameObject nari_kei;
    public static GameObject nari_fu;
    


    void Start()
    {
        gyoku = (GameObject)Resources.Load("gyoku");
        hisha = (GameObject)Resources.Load("hisha");
        kaku = (GameObject)Resources.Load("kaku");
        kin = (GameObject)Resources.Load("kin");
        gin = (GameObject)Resources.Load("gin");
        kei = (GameObject)Resources.Load("kei");
        kyou = (GameObject)Resources.Load("kyou");
        fu = (GameObject)Resources.Load("fu");
        ryuu = (GameObject)Resources.Load("ryuu");
        uma = (GameObject)Resources.Load("uma");
        nari_gin = (GameObject)Resources.Load("nari_gin");
        nari_kyou = (GameObject)Resources.Load("nari_kyou");
        nari_kei = (GameObject)Resources.Load("nari_kei");
        nari_fu = (GameObject)Resources.Load("nari_fu");

    }
    //盤面に駒を配置する
    public static void arrangement_ban(name_koma[,] koma, player[,] banmen)
    {
        
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                switch (koma[i, j])
                {
                    case name_koma.gyoku:
                        
                        if (banmen[i, j] == player.player1)
                        {

                            Instantiate_koma(gyoku, i, j, direction_player1);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(gyoku, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.hisha:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(hisha, i, j, direction_player1);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(hisha, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.kaku:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(kaku, i, j, direction_player1);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(kaku, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.kin:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(kin, i, j, direction_player1);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(kin, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.gin:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(gin, i, j, direction_player1);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(gin, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.kei:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(kei, i, j, direction_player1);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(kei, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.kyou:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(kyou, i, j, direction_player1);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(kyou, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.fu:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(fu, i, j, direction_player1);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(fu, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }

                    case name_koma.ryuu:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(ryuu, i, j, direction_player1);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(ryuu, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }

                    case name_koma.uma:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(uma, i, j, direction_player1);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(uma, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.nari_gin:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(nari_gin, i, j, direction_player1);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(nari_gin, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.nari_kei:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(nari_kei, i, j, direction_player1);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(nari_kei, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.nari_kyou:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(nari_kyou, i, j, direction_player1);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(nari_kyou, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.nari_fu:
                        
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate_koma(nari_fu, i, j, direction_player1);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate_koma(nari_fu, i, j, direction_player2);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    default:
                        break;
                }
            }
        }

    }

    public static void arrangement_motigoma(int[]  player1_motigoma, int[] player2_motigoma)
    {
        //持ち駒の配列を参照して持ち駒を配置
        foreach (name_motigoma moti in System.Enum.GetValues(typeof(name_motigoma)))
        {
            int i = (int)moti;
            for (int j = 0; j < player1_motigoma[i]; j++)
            {
                switch (moti)
                {
                    case name_motigoma.hisha:
                        
                        Instantiate(hisha, new Vector2(motigoma_player1_x + j * length_motigoma, motigoma_player1_y + i * length_motigoma), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.kaku:
                        
                        Instantiate(kaku, new Vector2(motigoma_player1_x + j * length_motigoma, motigoma_player1_y + i * length_motigoma), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.kin:
                        
                        Instantiate(kin, new Vector2(motigoma_player1_x + j * length_motigoma, motigoma_player1_y + i * length_motigoma), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.gin:
                        
                        Instantiate(gin, new Vector2(motigoma_player1_x + j * length_motigoma, motigoma_player1_y + i * length_motigoma), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.kei:
                        
                        Instantiate(kei, new Vector2(motigoma_player1_x + j * length_motigoma, motigoma_player1_y + i * length_motigoma), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.kyou:
                        
                        Instantiate(kyou, new Vector2(motigoma_player1_x + j * length_motigoma, motigoma_player1_y + i * length_motigoma), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.fu:
                        
                        Instantiate(fu, new Vector2(motigoma_player1_x + j * length_motigoma, motigoma_player1_y + i * length_motigoma), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    default:
                        break;




                }
            }
            for (int j = 0; j < player2_motigoma[i]; j++)
            {
                switch (moti)
                {
                    case name_motigoma.hisha:
                        
                        Instantiate(hisha, new Vector2(motigoma_player2_x + j * length_motigoma, motigoma_player2_y + i * length_motigoma), Quaternion.Euler(0f, 0f, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.kaku:
                        
                        Instantiate(kaku, new Vector2(motigoma_player2_x + j * length_motigoma, motigoma_player2_y + i * length_motigoma), Quaternion.Euler(0f, 0f, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.kin:
                        
                        Instantiate(kin, new Vector2(motigoma_player2_x + j * length_motigoma, motigoma_player2_y + i * length_motigoma), Quaternion.Euler(0f, 0f, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.gin:
                        
                        Instantiate(gin, new Vector2(motigoma_player2_x + j * length_motigoma, motigoma_player2_y + i * length_motigoma), Quaternion.Euler(0f, 0f, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.kei:
                        
                        Instantiate(kei, new Vector2(motigoma_player2_x + j * length_motigoma, motigoma_player2_y + i * length_motigoma), Quaternion.Euler(0f, 0f, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.kyou:
                        
                        Instantiate(kyou, new Vector2(motigoma_player2_x + j * length_motigoma, motigoma_player2_y + i * length_motigoma), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.fu:
                        
                        Instantiate(fu, new Vector2(motigoma_player2_x + j * length_motigoma, motigoma_player2_y + i * length_motigoma), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    default:
                        break;




                }
            }
        }
    }
    
}
