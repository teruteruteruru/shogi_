using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

//各駒の動きを記述したクラス
public class Koma_move : Instantiation
{
    
    public static GameObject select;

    void Start()
    {
        select = (GameObject)Resources.Load("select");
    }

    public static void Gyoku_move(name_koma[,] koma, player[,] banmen, int a, int b)
    {
        



        if (banmen[a, b] == player.player1)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9)
                    {
                        if (banmen[a + i, b + j] != player.player1)
                        {
                            Instantiate_koma(select, a+i, b+j, direction_player1);
                        }
                    }
                }
            }

        }
        else if (banmen[a, b] == player.player2)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9 && banmen[a + i, b + j] != player.player2)
                    {
                        if (banmen[a + i, b + j] != player.player2)
                        {
                            Instantiate_koma(select, a + i, b + j, direction_player1);
                        }
                    }
                }
            }

        }

    }

    public static void Hisha_move(name_koma[,] koma, player[,] banmen, int a, int b)
    {
        


        if (banmen[a, b] == player.player1)
        {
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b, direction_player1);
                        if (banmen[a + i, b] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b, direction_player1);
                        if (banmen[a + i, b] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a > -1 && a < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a, b + i] != player.player1)
                    {
                        Instantiate_koma(select, a, b + i, direction_player1);
                        if (banmen[a, b + i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a, b + i] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a > -1 && a < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a, b + i] != player.player1)
                    {
                        Instantiate_koma(select, a, b + i, direction_player1);
                        if (banmen[a, b + i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a, b + i] == player.player1)
                    {
                        break;
                    }
                }

            }


        }
        else if (banmen[a, b] == player.player2)
        {
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b, direction_player1);
                        if (banmen[a + i, b] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b, direction_player1);
                        if (banmen[a + i, b] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a > -1 && a < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a, b + i] != player.player2)
                    {
                        Instantiate_koma(select, a, b + i, direction_player1);
                        if (banmen[a, b + i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a, b + i] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a > -1 && a < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a, b + i] != player.player2)
                    {
                        Instantiate_koma(select, a, b + i, direction_player1);
                        if (banmen[a, b + i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a, b + i] == player.player2)
                    {
                        break;
                    }
                }

            }

        }

    }

    public static void Kaku_move(name_koma[,] koma, player[,] banmen, int a, int b)
    {
        


        if (banmen[a, b] == player.player1)
        {
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a + i, b + i] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b + i, direction_player1); 
                        if (banmen[a + i, b + i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b + i] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b - i > -1 && b - i < 9)
                {
                    if (banmen[a + i, b - i] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b - i, direction_player1); 
                        if (banmen[a + i, b - i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b - i] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a - i > -1 && a - i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a - i, b + i] != player.player1)
                    {
                        Instantiate_koma(select, a - i, b + i, direction_player1); 
                        if (banmen[a - i, b + i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a - i, b + i] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a + i > -1 && a + i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a + i, b + i] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b + i, direction_player1); 
                        if (banmen[a + i, b + i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b + i] == player.player1)
                    {
                        break;
                    }
                }

            }


        }
        else if (banmen[a, b] == player.player2)
        {
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a + i, b + i] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b + i, direction_player1); 
                        if (banmen[a + i, b + i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b + i] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b - i > -1 && b - i < 9)
                {
                    if (banmen[a + i, b - i] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b - i, direction_player1); 
                        if (banmen[a + i, b - i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b - i] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a - i > -1 && a - i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a - i, b + i] != player.player2)
                    {
                        Instantiate_koma(select, a - i, b + i, direction_player1); 
                        if (banmen[a - i, b + i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a - i, b + i] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a + i > -1 && a + i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a + i, b + i] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b + i, direction_player1);
                        if (banmen[a + i, b + i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b + i] == player.player2)
                    {
                        break;
                    }
                }

            }
        }
    }
    public static void Kin_move(name_koma[,] koma, player[,] banmen, int a, int b)
    {
        



        if (banmen[a, b] == player.player1)
        {
            for (int i = 0; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9)
                    {
                        if (banmen[a + i, b + j] != player.player1)
                        {
                            Instantiate_koma(select, a + i, b + j, direction_player1);
                        }
                    }
                }
            }
            if (a - 1 > -1 && a - 1 < 9 && b > -1 && b < 9)
            {
                if (banmen[a - 1, b] != player.player1)
                {
                    Instantiate_koma(select, a - 1, b, direction_player1);
                }
            }

        }
        else if (banmen[a, b] == player.player2)
        {
            for (int i = -1; i <= 0; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9)
                    {
                        if (banmen[a + i, b + j] != player.player2)
                        {
                            Instantiate_koma(select, a + i, b + j, direction_player1);
                        }
                    }
                }
            }
            if (a + 1 > -1 && a + 1 < 9 && b > -1 && b < 9)
            {
                if (banmen[a + 1, b] != player.player2)
                {
                    Instantiate_koma(select, a + 1, b, direction_player1);
                }
            }

        }
    }

    public static void Gin_move(name_koma[,] koma, player[,] banmen, int a, int b)
    {

        



        if (banmen[a, b] == player.player1)
        {

            for (int j = -1; j <= 1; j++)
            {
                int i = 1;
                if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9)
                {
                    if (banmen[a + i, b + j] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b + j, direction_player1);
                    }
                }
            }

            if (a - 1 > -1 && a - 1 < 9 && b - 1 > -1 && b - 1 < 9)
            {
                if (banmen[a - 1, b - 1] != player.player1)
                {
                    Instantiate_koma(select, a - 1, b - 1, direction_player1);
                }
            }
            if (a - 1 > -1 && a - 1 < 9 && b + 1 > -1 && b + 1 < 9)
            {
                if (banmen[a - 1, b + 1] != player.player1)
                {
                    Instantiate_koma(select, a - 1, b + 1, direction_player1);
                }
            }

        }
        else if (banmen[a, b] == player.player2)
        {

            for (int j = -1; j <= 1; j++)
            {
                int i = -1;
                if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9)
                {
                    if (banmen[a + i, b + j] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b + j, direction_player1);
                    }
                }

            }
            if (a + 1 > -1 && a + 1 < 9 && b - 1 > -1 && b - 1 < 9)
            {
                if (banmen[a + 1, b - 1] != player.player2)
                {
                    Instantiate_koma(select, a + 1, b - 1, direction_player1);
                }
            }
            if (a + 1 > -1 && a + 1 < 9 && b + 1 > -1 && b + 1 < 9)
            {
                if (banmen[a + 1, b + 1] != player.player2)
                {
                    Instantiate_koma(select, a + 1, b + 1, direction_player1);
                }
            }

        }
    }

    public static void Kei_move(name_koma[,] koma, player[,] banmen, int a, int b)
    {

        

        if (banmen[a, b] == player.player1)
        {
            if (a + 2 > -1 && a + 2 < 9 && b - 1 > -1 && b - 1 < 9)
            {
                if (banmen[a + 2, b - 1] != player.player1)
                {
                    Instantiate_koma(select, a + 2, b - 1, direction_player1);
                }
            }
            if (a + 2 > -1 && a + 2 < 9 && b + 1 > -1 && b + 1 < 9)
            {
                if (banmen[a + 2, b + 1] != player.player1)
                {
                    Instantiate_koma(select, a + 2, b - 1, direction_player1);
                }
            }

        }
        else if (banmen[a, b] == player.player2)
        {
            if (a - 2 > -1 && a - 2 < 9 && b - 1 > -1 && b - 1 < 9)
            {
                if (banmen[a - 2, b - 1] != player.player2)
                {
                    Instantiate_koma(select, a - 2, b - 1, direction_player1);
                }
            }
            if (a - 2 > -1 && a - 2 < 9 && b + 1 > -1 && b + 1 < 9)
            {
                if (banmen[a - 2, b + 1] != player.player2)
                {
                    Instantiate_koma(select, a - 2, b + 1, direction_player1);
                }
            }
        }

    }

    public static void Kyou_move(name_koma[,] koma, player[,] banmen, int a, int b)
    {

        

        if (banmen[a, b] == player.player1)
        {
            for (int i = 1; i < 9; i++)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b, direction_player1);
                        if (banmen[a + i, b] == player.player2)
                        {
                            break;

                        }
                    }
                    else if (banmen[a + i, b] == player.player1)
                    {
                        break;
                    }
                }

            }
        }
        else if (banmen[a, b] == player.player2)
        {
            for (int i = 1; i < 9; i++)
            {
                if (a - i > -1 && a - i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a - i, b] != player.player2)
                    {
                        Instantiate_koma(select, a - i, b, direction_player1);
                        if (banmen[a - i, b] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a - i, b] == player.player2)
                    {
                        break;
                    }
                }
            }
        }
    }

    public static void Fu_move(name_koma[,] koma, player[,] banmen, int a, int b)
    {
        
        if (banmen[a, b] == player.player1)
        {
            if (a + 1 > -1 && a + 1 < 9 && b > -1 && b < 9)
            {
                if (banmen[a + 1, b] != player.player1)
                {
                    Instantiate_koma(select, a + 1, b, direction_player1);
                }
            }
        }
        else if (banmen[a, b] == player.player2)
        {
            if (a - 1 > -1 && a - 1 < 9 && b > -1 && b < 9)
            {
                if (banmen[a - 1, b] != player.player2)
                {
                    Instantiate_koma(select, a - 1, b, direction_player1);
                }
            }
        }
    }



    public static void Uma_move(name_koma[,] koma, player[,] banmen, int a, int b)
    {
        
        if (banmen[a, b] == player.player1)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9)
                    {
                        if (banmen[a + i, b + j] != player.player1)
                        {
                            Instantiate_koma(select, a + i, b + j, direction_player1);
                        }
                    }
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a + i, b + i] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b + i, direction_player1);
                        if (banmen[a + i, b + i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b + i] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b - i > -1 && b - i < 9)
                {
                    if (banmen[a + i, b - i] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b + i, direction_player1);
                        if (banmen[a + i, b - i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b - i] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a - i > -1 && a - i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a - i, b + i] != player.player1)
                    {
                        Instantiate_koma(select, a - i, b + i, direction_player1);
                        if (banmen[a - i, b + i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a - i, b + i] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a + i > -1 && a + i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a + i, b + i] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b + i, direction_player1);
                        if (banmen[a + i, b + i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b + i] == player.player1)
                    {
                        break;
                    }
                }

            }


        }
        else if (banmen[a, b] == player.player2)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9 && banmen[a + i, b + j] != player.player2)
                    {
                        if (banmen[a + i, b + j] != player.player2)
                        {
                            Instantiate_koma(select, a + i, b + j, direction_player1);
                        }
                    }
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a + i, b + i] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b + i, direction_player1);
                        if (banmen[a + i, b + i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b + i] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b - i > -1 && b - i < 9)
                {
                    if (banmen[a + i, b - i] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b - i, direction_player1);
                        if (banmen[a + i, b - i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b - i] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a - i > -1 && a - i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a - i, b + i] != player.player2)
                    {
                        Instantiate_koma(select, a - i, b + i, direction_player1); 
                        if (banmen[a - i, b + i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a - i, b + i] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a + i > -1 && a + i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a + i, b + i] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b + i, direction_player1);
                        if (banmen[a + i, b + i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b + i] == player.player2)
                    {
                        break;
                    }
                }

            }

        }
    }

    public static void Ryuu_move(name_koma[,] koma, player[,] banmen, int a, int b)
    {
        
        
        if (banmen[a, b] == player.player1)
        {
            
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9)
                    {
                        if (banmen[a + i, b + j] != player.player1)
                        {
                            Instantiate_koma(select, a + i, b + j, direction_player1);
                        }
                    }
                }
            }

            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b, direction_player1);
                        if (banmen[a + i, b] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player1)
                    {
                        Instantiate_koma(select, a + i, b, direction_player1);
                        if (banmen[a + i, b] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a > -1 && a < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a, b + i] != player.player1)
                    {
                        Instantiate_koma(select, a , b + i, direction_player1); 
                        if (banmen[a, b + i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a, b + i] == player.player1)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a > -1 && a < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a, b + i] != player.player1)
                    {
                        Instantiate_koma(select, a , b + i, direction_player1);
                        if (banmen[a, b + i] == player.player2)
                        {
                            break;
                        }
                    }
                    else if (banmen[a, b + i] == player.player1)
                    {
                        break;
                    }
                }

            }

        }
        else if (banmen[a, b] == player.player2)
        {
            
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9 && banmen[a + i, b + j] != player.player2)
                    {
                        if (banmen[a + i, b + j] != player.player2)
                        {
                            Instantiate_koma(select, a + i, b + j, direction_player1);
                        }
                    }
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b, direction_player1); if (banmen[a + i, b] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player2)
                    {
                        Instantiate_koma(select, a + i, b, direction_player1); if (banmen[a + i, b] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a + i, b] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= 8; i++)
            {
                if (a > -1 && a < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a, b + i] != player.player2)
                    {
                        Instantiate_koma(select, a , b + i, direction_player1); if (banmen[a, b + i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a, b + i] == player.player2)
                    {
                        break;
                    }
                }

            }
            for (int i = -1; i >= -8; i--)
            {
                if (a > -1 && a < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a, b + i] != player.player2)
                    {
                        Instantiate_koma(select, a , b + i, direction_player1); 
                        if (banmen[a, b + i] == player.player1)
                        {
                            break;
                        }
                    }
                    else if (banmen[a, b + i] == player.player2)
                    {
                        break;
                    }
                }

            }

        }
    }
    
}
