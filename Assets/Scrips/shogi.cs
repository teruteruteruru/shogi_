using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

using UnityEditor;



public enum name_koma
{
    nashi = 0, gyoku = 1, hisha = 2, kaku = 3, kin = 4, gin = 5, kei = 6, kyou = 7, fu = 8, uma = 9, ryuu = 10, nari_gin = 11, nari_kei = 12, nari_kyou = 13, nari_fu = 14
}

public enum name_motigoma
{
    hisha, kaku, kin, gin, kei, kyou, fu
}


//player1: 下側　player2: 上側
public enum player
{
    player1 = 1, player2 = 2
}

public class shogi : MonoBehaviour
{
    public player turn;
    public Text winner;
    public AudioClip sound1;
    public AudioClip sound2;
    


    private AudioSource audioSource;



    private GameObject click_koma;
    private player[,] banmen = new player[9, 9];
    private name_koma[,] koma = new name_koma[9, 9];
    private GameObject selectobj;
    private int[] player1_motigoma = new int[7];
    private int[] player2_motigoma = new int[7];


    private int[] selectkoma = new int[2];
    private int[] random_koma = new int[100];
    public int random_koma_pub;


    //駒の配置
    void haiti()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                switch (koma[i, j])
                {
                    case name_koma.gyoku:


                        GameObject gyoku = (GameObject)Resources.Load("gyoku");
                        if (banmen[i, j] == player.player1)
                        {

                            Instantiate(gyoku, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(gyoku, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.hisha:
                        GameObject hisha = (GameObject)Resources.Load("hisha");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(hisha, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(hisha, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.kaku:
                        GameObject kaku = (GameObject)Resources.Load("kaku");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(kaku, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(kaku, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.kin:
                        GameObject kin = (GameObject)Resources.Load("kin");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(kin, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(kin, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.gin:
                        GameObject gin = (GameObject)Resources.Load("gin");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(gin, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(gin, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.kei:
                        GameObject kei = (GameObject)Resources.Load("kei");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(kei, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(kei, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.kyou:
                        GameObject kyou = (GameObject)Resources.Load("kyou");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(kyou, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(kyou, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.fu:
                        GameObject fu = (GameObject)Resources.Load("fu");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(fu, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(fu, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }

                    case name_koma.ryuu:
                        GameObject ryuu = (GameObject)Resources.Load("ryuu");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(ryuu, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(ryuu, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }

                    case name_koma.uma:
                        GameObject uma = (GameObject)Resources.Load("uma");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(uma, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(uma, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.nari_gin:
                        GameObject nari_gin = (GameObject)Resources.Load("nari_gin");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(nari_gin, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(nari_gin, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.nari_kei:
                        GameObject nari_kei = (GameObject)Resources.Load("nari_kei");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(nari_kei, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(nari_kei, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.nari_kyou:
                        GameObject nari_kyou = (GameObject)Resources.Load("nari_kyou");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(nari_kyou, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(nari_kyou, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case name_koma.nari_fu:
                        GameObject nari_fu = (GameObject)Resources.Load("nari_fu");
                        if (banmen[i, j] == player.player1)
                        {
                            Instantiate(nari_fu, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(i, j);

                            break;
                        }
                        else if (banmen[i, j] == player.player2)
                        {
                            Instantiate(nari_fu, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);
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

    void motigoma()
    {
        foreach (name_motigoma moti in System.Enum.GetValues(typeof(name_motigoma)))
        {
            int i = (int)moti;
            for (int j = 0; j < player1_motigoma[i]; j++)
            {
                switch (moti)
                {
                    case name_motigoma.hisha:
                        GameObject hisha = (GameObject)Resources.Load("hisha");
                        Instantiate(hisha, new Vector2(6f + j * 0.25f, 0 + 0.3f * i), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.kaku:
                        GameObject kaku = (GameObject)Resources.Load("kaku");
                        Instantiate(kaku, new Vector2(6f + j * 0.25f, 0 + 0.35f * i), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.kin:
                        GameObject kin = (GameObject)Resources.Load("kin");
                        Instantiate(kin, new Vector2(6f + j * 0.25f, 0 + 0.25f * i), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.gin:
                        GameObject gin = (GameObject)Resources.Load("gin");
                        Instantiate(gin, new Vector2(6f + j * 0.25f, 0 + 0.25f * i), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.kei:
                        GameObject kei = (GameObject)Resources.Load("kei");
                        Instantiate(kei, new Vector2(6f + j * 0.25f, 0 + 0.25f * i), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.kyou:
                        GameObject kyou = (GameObject)Resources.Load("kyou");
                        Instantiate(kyou, new Vector2(6f + j * 0.25f, 0 + 0.25f * i), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
                        break;
                    case name_motigoma.fu:
                        GameObject fu = (GameObject)Resources.Load("fu");
                        Instantiate(fu, new Vector2(6f + j * 0.25f, 0 + 0.25f * i), Quaternion.Euler(0, 0, 0)).GetComponent<koma_here>().Here(9, i);
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
                        GameObject hisha = (GameObject)Resources.Load("hisha");
                        Instantiate(hisha, new Vector2(-6f + j * 0.25f, 0 + 0.3f * i), Quaternion.Euler(0f, 0f, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.kaku:
                        GameObject kaku = (GameObject)Resources.Load("kaku");
                        Instantiate(kaku, new Vector2(-6f + j * 0.25f, 0 + 0.3f * i), Quaternion.Euler(0f, 0f, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.kin:
                        GameObject kin = (GameObject)Resources.Load("kin");
                        Instantiate(kin, new Vector2(-6f + j * 0.25f, 0 + 0.25f * i), Quaternion.Euler(0f, 0f, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.gin:
                        GameObject gin = (GameObject)Resources.Load("gin");
                        Instantiate(gin, new Vector2(-6f + j * 0.25f, 0 + 0.25f * i), Quaternion.Euler(0f, 0f, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.kei:
                        GameObject kei = (GameObject)Resources.Load("kei");
                        Instantiate(kei, new Vector2(-6f + j * 0.25f, 0 + 0.25f * i), Quaternion.Euler(0f, 0f, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.kyou:
                        GameObject kyou = (GameObject)Resources.Load("kyou");
                        Instantiate(kyou, new Vector2(-6f + j * 0.25f, 0 + 0.25f * i), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    case name_motigoma.fu:
                        GameObject fu = (GameObject)Resources.Load("fu");
                        Instantiate(fu, new Vector2(-6f + j * 0.25f, 0 + 0.25f * i), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(10, i);
                        break;
                    default:
                        break;




                }
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        for(int i = 0; i < 100; i++)
        {
            if (i < 15)
            {
                random_koma[i] = 1; //ryuu
            }
            if(i < 31&&i>=15)
            {
                random_koma[i] = 2; //uma
            }
            if(i>=31)
            {
                random_koma[i] = 0; //kin
            }
        }
        //初手プレイヤーの決定
        int ramdom = UnityEngine.Random.Range(0, 2);
        if (ramdom == 0)
        {
            turn = player.player1;
        }
        else
        {
            turn = player.player2;
        }
        //盤面の初期化



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
        //駒の配置
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

        haiti();

    }
    //駒の動き
    void gyoku_move(int a, int b)
    {
        GameObject select = (GameObject)Resources.Load("select");



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
                            Instantiate(select, new Vector2(3.75f - (b + j) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + j);
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
                            Instantiate(select, new Vector2(3.75f - (b + j) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + j);
                        }
                    }
                }
            }

        }

    }

    void hisha_move(int a, int b)
    {
        GameObject select = (GameObject)Resources.Load("select");


        if (banmen[a, b] == player.player1)
        {
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player1)
                    {
                        Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a, b + i);
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

    void kaku_move(int a, int b)
    {
        GameObject select = (GameObject)Resources.Load("select");


        if (banmen[a, b] == player.player1)
        {
            for (int i = 1; i <= 8; i++)
            {
                if (a + i > -1 && a + i < 9 && b + i > -1 && b + i < 9)
                {
                    if (banmen[a + i, b + i] != player.player1)
                    {
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b - i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b - i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - i, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b - i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b - i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - i, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + i);
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
    void kin_move(int a, int b)
    {
        GameObject select = (GameObject)Resources.Load("select");



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
                            Instantiate(select, new Vector2(3.75f - (b + j) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + j);
                        }
                    }
                }
            }
            if (a - 1 > -1 && a - 1 < 9 && b > -1 && b < 9)
            {
                if (banmen[a - 1, b] != player.player1)
                {
                    Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - 1) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - 1, b);
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
                            Instantiate(select, new Vector2(3.75f - (b + j) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + j);
                        }
                    }
                }
            }
            if (a + 1 > -1 && a + 1 < 9 && b > -1 && b < 9)
            {
                if (banmen[a + 1, b] != player.player2)
                {
                    Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + 1) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + 1, b);
                }
            }

        }
    }

    void gin_move(int a, int b)
    {

        GameObject select = (GameObject)Resources.Load("select");



        if (banmen[a, b] == player.player1)
        {

            for (int j = -1; j <= 1; j++)
            {
                int i = 1;
                if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9)
                {
                    if (banmen[a + i, b + j] != player.player1)
                    {
                        Instantiate(select, new Vector2(3.75f - (b + j) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + j);
                    }
                }
            }

            if (a - 1 > -1 && a - 1 < 9 && b - 1 > -1 && b - 1 < 9)
            {
                if (banmen[a - 1, b - 1] != player.player1)
                {
                    Instantiate(select, new Vector2(3.75f - (b - 1) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - 1) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - 1, b - 1);
                }
            }
            if (a - 1 > -1 && a - 1 < 9 && b + 1 > -1 && b + 1 < 9)
            {
                if (banmen[a - 1, b + 1] != player.player1)
                {
                    Instantiate(select, new Vector2(3.75f - (b + 1) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - 1) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - 1, b + 1);
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
                        Instantiate(select, new Vector2(3.75f - (b + j) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + j);
                    }
                }

            }
            if (a + 1 > -1 && a + 1 < 9 && b - 1 > -1 && b - 1 < 9)
            {
                if (banmen[a + 1, b - 1] != player.player2)
                {
                    Instantiate(select, new Vector2(3.75f - (b - 1) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + 1) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + 1, b - 1);
                }
            }
            if (a + 1 > -1 && a + 1 < 9 && b + 1 > -1 && b + 1 < 9)
            {
                if (banmen[a + 1, b + 1] != player.player2)
                {
                    Instantiate(select, new Vector2(3.75f - (b + 1) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + 1) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + 1, b + 1);
                }
            }

        }
    }

    void kei_move(int a, int b)
    {

        GameObject select = (GameObject)Resources.Load("select");

        if (banmen[a, b] == player.player1)
        {
            if (a + 2 > -1 && a + 2 < 9 && b - 1 > -1 && b - 1 < 9)
            {
                if (banmen[a + 2, b - 1] != player.player1)
                {
                    Instantiate(select, new Vector2(3.75f - (b - 1) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + 2) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + 2, b - 1);
                }
            }
            if (a + 2 > -1 && a + 2 < 9 && b + 1 > -1 && b + 1 < 9)
            {
                if (banmen[a + 2, b + 1] != player.player1)
                {
                    Instantiate(select, new Vector2(3.75f - (b + 1) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + 2) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + 2, b + 1);
                }
            }

        }
        else if (banmen[a, b] == player.player2)
        {
            if (a - 2 > -1 && a - 2 < 9 && b - 1 > -1 && b - 1 < 9)
            {
                if (banmen[a - 2, b - 1] != player.player2)
                {
                    Instantiate(select, new Vector2(3.75f - (b - 1) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - 2) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - 2, b - 1);
                }
            }
            if (a - 2 > -1 && a - 2 < 9 && b + 1 > -1 && b + 1 < 9)
            {
                if (banmen[a - 2, b + 1] != player.player2)
                {
                    Instantiate(select, new Vector2(3.75f - (b + 1) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - 2) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - 2, b + 1);
                }
            }
        }

    }

    void kyou_move(int a, int b)
    {

        GameObject select = (GameObject)Resources.Load("select");

        if (banmen[a, b] == player.player1)
        {
            for (int i = 1; i < 9; i++)
            {
                if (a + i > -1 && a + i < 9 && b > -1 && b < 9)
                {
                    if (banmen[a + i, b] != player.player1)
                    {
                        Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - i, b);
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

    void fu_move(int a, int b)
    {
        GameObject select = (GameObject)Resources.Load("select");
        if (banmen[a, b] == player.player1)
        {
            if (a + 1 > -1 && a + 1 < 9 && b > -1 && b < 9)
            {
                if (banmen[a + 1, b] != player.player1)
                {
                    Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + 1) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + 1, b);
                }
            }
        }
        else if (banmen[a, b] == player.player2)
        {
            if (a - 1 > -1 && a - 1 < 9 && b > -1 && b < 9)
            {
                if (banmen[a - 1, b] != player.player2)
                {
                    Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - 1) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - 1, b);
                }
            }
        }
    }



    void uma_move(int a, int b)
    {
        GameObject select = (GameObject)Resources.Load("select");
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
                            Instantiate(select, new Vector2(3.75f - (b + j) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + j);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b - i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b - i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - i, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + i);
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
                            Instantiate(select, new Vector2(3.75f - (b + j) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + j);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b - i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b - i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a - i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a - i, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + i);
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

    void ryuu_move(int a, int b)
    {
        GameObject select = (GameObject)Resources.Load("select");
        Debug.Log("koko1");
        if (banmen[a, b] == player.player1)
        {
            Debug.Log("koko2");
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9)
                    {
                        if (banmen[a + i, b + j] != player.player1)
                        {
                            Instantiate(select, new Vector2(3.75f - (b + j) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + j);
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
                        Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a, b + i);
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
            Debug.Log("koko3");
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (a + i > -1 && a + i < 9 && b + j > -1 && b + j < 9 && banmen[a + i, b + j] != player.player2)
                    {
                        if (banmen[a + i, b + j] != player.player2)
                        {
                            Instantiate(select, new Vector2(3.75f - (b + j) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b + j);
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
                        Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a + i) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a + i, b);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a, b + i);
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
                        Instantiate(select, new Vector2(3.75f - (b + i) * (6.4f / 9f) + (6.4f / 18f), -3.3f + (a) * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(a, b + i);
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

    void get_koma(int a, int b)
    {
        if (koma[a, b] == name_koma.gyoku)
        {
            if (turn == player.player1)
            {
                winner.text = "Winner:Player1";
            }
            else if (turn == player.player2)
            {
                winner.text = "Winner:Player2";
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

    void nifu()
    {
        GameObject select = (GameObject)Resources.Load("select");
        int[] nifu = new int[9];
        for (int i = 0; i < 9; i++)
        {
            int m = 0;
            for (int j = 0; j < 9; j++)
            {
                if (koma[j, i] == name_koma.fu && banmen[j, i] == turn)
                {
                    m++;

                }
            }
            if (m == 0)
            {
                nifu[i] = 1;

            }


        }
        for (int j = 0; j < 9; j++)
        {
            Debug.Log("j:" + j);
            if (nifu[j] == 0)
            {
                continue;

            }
            for (int i = 0; i < 9; i++)
            {
                if (banmen[i, j] == 0)
                {
                    Instantiate(select, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);

                }
            }
        }
    }

    IEnumerator narikin(int a, int b, int k, int l)
    {
        UnityEngine.Debug.Log(a);
        UnityEngine.Debug.Log(turn);
        if (a > 5 && turn == player.player1)
        {
            UnityEngine.Debug.Log("narikin");
            GameObject window = GameObject.Find("window");
            window.GetComponent<window>().nari(0);
            bool isOK = window.GetComponent<window>().yes_no;
            bool isClicked = window.GetComponent<window>().isClicked;
            while (!isClicked)
            {
                isClicked = window.GetComponent<window>().isClicked;
                isOK = window.GetComponent<window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }

            if (isOK)
            {
                if (koma[k, l] == name_koma.gin)
                {
                    koma[a, b] = name_koma.nari_gin;
                }
                else if (koma[k, l] == name_koma.kei)
                {
                    koma[a, b] = name_koma.nari_kei;
                }
                else if (koma[k, l] == name_koma.kyou)
                {
                    koma[a, b] = name_koma.nari_kyou;
                }
                else if (koma[k, l] == name_koma.fu)
                {
                    koma[a, b] = name_koma.nari_fu;
                }
            }


        }
        else if (a < 3 && turn == player.player2)
        {
            UnityEngine.Debug.Log("naririkin");
            GameObject window = GameObject.Find("window");
            window.GetComponent<window>().nari(0);
            bool isOK = window.GetComponent<window>().yes_no;
            bool isClicked = window.GetComponent<window>().isClicked;
            while (!isClicked)
            {
                isClicked = window.GetComponent<window>().isClicked;
                isOK = window.GetComponent<window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }
            if (isOK)
            {
                if (koma[k, l] == name_koma.gin)
                {
                    koma[a, b] = name_koma.nari_gin;
                }
                else if (koma[k, l] == name_koma.kei)
                {
                    koma[a, b] = name_koma.nari_kei;
                }
                else if (koma[k, l] == name_koma.kyou)
                {
                    koma[a, b] = name_koma.nari_kyou;
                }
                else if (koma[k, l] == name_koma.fu)
                {
                    koma[a, b] = name_koma.nari_fu;
                }


            }
        }

        yield break;
    }



    IEnumerator nariryuu(int a, int b, int k, int l)
    {
        UnityEngine.Debug.Log(a);
        UnityEngine.Debug.Log(turn);
        if (a > 5 && turn == player.player1)
        {
            UnityEngine.Debug.Log("nariryuu");
            GameObject window = GameObject.Find("window");
            window.GetComponent<window>().nari(1);
            bool isOK = window.GetComponent<window>().yes_no;
            bool isClicked = window.GetComponent<window>().isClicked;
            while (!isClicked)
            {
                isClicked = window.GetComponent<window>().isClicked;
                isOK = window.GetComponent<window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }

            if (isOK)
            {
                koma[a, b] = name_koma.ryuu;
               

            }

        }
        else if (a < 3 && turn == player.player2)
        {
            UnityEngine.Debug.Log("nariryuu");
            GameObject window = GameObject.Find("window");
            window.GetComponent<window>().nari(1);
            bool isOK = window.GetComponent<window>().yes_no;
            bool isClicked = window.GetComponent<window>().isClicked;
            while (!isClicked)
            {
                isClicked = window.GetComponent<window>().isClicked;
                isOK = window.GetComponent<window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }
            if (isOK)
            {
                koma[a, b] = name_koma.ryuu;
                

            }

        }

        yield break;

    }
    IEnumerator nariryuu_ran(int a, int b, int k, int l)
    {
        UnityEngine.Debug.Log(a);
        UnityEngine.Debug.Log(turn);
        if (a > 5 && turn == player.player1)
        {
            UnityEngine.Debug.Log("nariryuu");
            GameObject window = GameObject.Find("window");
            window.GetComponent<window>().nari(0);
            bool isOK = window.GetComponent<window>().yes_no;
            bool isClicked = window.GetComponent<window>().isClicked;
            while (!isClicked)
            {
                isClicked = window.GetComponent<window>().isClicked;
                isOK = window.GetComponent<window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }

            if (isOK)
            {
                koma[a, b] = name_koma.ryuu;
                audioSource.PlayOneShot(sound1);

            }

        }
        else if (a < 3 && turn == player.player2)
        {
            UnityEngine.Debug.Log("nariryuu");
            GameObject window = GameObject.Find("window");
            window.GetComponent<window>().nari(0);
            bool isOK = window.GetComponent<window>().yes_no;
            bool isClicked = window.GetComponent<window>().isClicked;
            while (!isClicked)
            {
                isClicked = window.GetComponent<window>().isClicked;
                isOK = window.GetComponent<window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }
            if (isOK)
            {
                koma[a, b] = name_koma.ryuu;
                audioSource.PlayOneShot(sound1);

            }

        }

        yield break;

    }

    IEnumerator nariuma(int a, int b, int k, int l)
    {
        UnityEngine.Debug.Log(a);
        UnityEngine.Debug.Log(turn);

        if (a > 5 && turn == player.player1)
        {
            UnityEngine.Debug.Log("nariuma");
            GameObject window = GameObject.Find("window");
            window.GetComponent<window>().nari(2);
            bool isOK = window.GetComponent<window>().yes_no;
            bool isClicked = window.GetComponent<window>().isClicked;
            while (!isClicked)
            {
                isClicked = window.GetComponent<window>().isClicked;
                isOK = window.GetComponent<window>().yes_no;
                UnityEngine.Debug.Log("isClicked:false");
                Debug.Log(isClicked);
                yield return null;
            }

            if (isOK)
            {
                koma[a, b] = name_koma.uma;
                

            }


        }
        else if (a < 3 && turn == player.player2)
        {
            UnityEngine.Debug.Log("nariuma");
            GameObject window = GameObject.Find("window");
            window.GetComponent<window>().nari(2);
            bool isOK = window.GetComponent<window>().yes_no;
            bool isClicked = window.GetComponent<window>().isClicked;
            while (!isClicked)
            {
                isClicked = window.GetComponent<window>().isClicked;
                isOK = window.GetComponent<window>().yes_no;
                UnityEngine.Debug.Log("isClicked:false");
                Debug.Log(isClicked);
                yield return null;
            }
            if (isOK)
            {
                koma[a, b] = name_koma.uma;
                

            }

        }

        yield break;

    }
    IEnumerator nariuma_ran(int a, int b, int k, int l)
    {
        UnityEngine.Debug.Log(a);
        UnityEngine.Debug.Log(turn);

        if (a > 5 && turn == player.player1)
        {
            UnityEngine.Debug.Log("nariuma");
            GameObject window = GameObject.Find("window");
            window.GetComponent<window>().nari(0);
            bool isOK = window.GetComponent<window>().yes_no;
            bool isClicked = window.GetComponent<window>().isClicked;
            while (!isClicked)
            {
                isClicked = window.GetComponent<window>().isClicked;
                isOK = window.GetComponent<window>().yes_no;
                UnityEngine.Debug.Log("isClicked:false");
                Debug.Log(isClicked);
                yield return null;
            }

            if (isOK)
            {
                koma[a, b] = name_koma.uma;
                audioSource.PlayOneShot(sound1);

            }


        }
        else if (a < 3 && turn == player.player2)
        {
            UnityEngine.Debug.Log("nariuma");
            GameObject window = GameObject.Find("window");
            window.GetComponent<window>().nari(0);
            bool isOK = window.GetComponent<window>().yes_no;
            bool isClicked = window.GetComponent<window>().isClicked;
            while (!isClicked)
            {
                isClicked = window.GetComponent<window>().isClicked;
                isOK = window.GetComponent<window>().yes_no;
                UnityEngine.Debug.Log("isClicked:false");
                Debug.Log(isClicked);
                yield return null;
            }
            if (isOK)
            {
                koma[a, b] = name_koma.uma;
                audioSource.PlayOneShot(sound1);

            }

        }

        yield break;

    }
    IEnumerator select_select(int a, int b)
    {

        Debug.Log("select");
        GameObject[] selects = GameObject.FindGameObjectsWithTag("select");
        GameObject[] komas = GameObject.FindGameObjectsWithTag("koma");
        audioSource.PlayOneShot(sound2);
        if (banmen[a, b] != turn)
        {
            get_koma(a, b);
        }

        foreach (GameObject koma in komas)
        {
            Destroy(koma);
        }

        int k = selectkoma[0];
        int l = selectkoma[1];

        Debug.Log("k:" + k);
        Debug.Log("l:" + l);


        if (k > -1 && k < 9 && l > -1 && l < 9)
        {
            koma[a, b] = koma[k, l];
            banmen[a, b] = turn;


            if (koma[k, l] == name_koma.gin || koma[k, l] == name_koma.kei || koma[k, l] == name_koma.kyou || koma[k, l] == name_koma.fu)
            {
                int ran = Random.Range(0, 100);
                random_koma_pub = random_koma[ran];
                Debug.Log(random_koma[ran]);
                if (random_koma[ran] == 1)
                {
                    yield return StartCoroutine(nariryuu_ran(a, b, k, l));
                }
                else if(random_koma[ran] == 2)
                {
                    yield return StartCoroutine(nariuma_ran(a, b, k, l));
                }
                else if (random_koma[ran] == 0)
                {
                    yield return StartCoroutine(narikin(a, b, k, l));
                }



            }
            else if (koma[k, l] == name_koma.kaku)
            {
                yield return StartCoroutine(nariuma(a, b, k, l));

            }
            else if (koma[k, l] == name_koma.hisha)
            {
                yield return StartCoroutine(nariryuu(a, b, k, l));

            }

            koma[k, l] = 0;
            banmen[k, l] = 0;
        }
        else if (k == 9 && turn == player.player1)
        {
            banmen[a, b] = player.player1;
            if (l == 0)
            {
                koma[a, b] = name_koma.hisha;
                player1_motigoma[0]--;
            }
            else if (l == 1)
            {
                koma[a, b] = name_koma.kaku;
                player1_motigoma[1]--;
            }
            else if (l == 2)
            {
                koma[a, b] = name_koma.kin;
                player1_motigoma[2]--;
            }
            else if (l == 3)
            {
                koma[a, b] = name_koma.gin;
                player1_motigoma[3]--;
            }
            else if (l == 4)
            {
                koma[a, b] = name_koma.kei;
                player1_motigoma[4]--;
            }
            else if (l == 5)
            {
                koma[a, b] = name_koma.kyou;
                player1_motigoma[5]--;
            }
            else if (l == 6)
            {
                koma[a, b] = name_koma.fu;
                player1_motigoma[6]--;
            }
        }
        else if (k == 10 && turn == player.player2)
        {
            banmen[a, b] = player.player2;
            if (l == 0)
            {
                koma[a, b] = name_koma.hisha;
                player2_motigoma[0]--;
            }
            else if (l == 1)
            {
                koma[a, b] = name_koma.kaku;
                player2_motigoma[1]--;
            }
            else if (l == 2)
            {
                koma[a, b] = name_koma.kin;
                player2_motigoma[2]--;
            }
            else if (l == 3)
            {
                koma[a, b] = name_koma.gin;
                player2_motigoma[3]--;
            }
            else if (l == 4)
            {
                koma[a, b] = name_koma.kei;
                player2_motigoma[4]--;
            }
            else if (l == 5)
            {
                koma[a, b] = name_koma.kyou;
                player2_motigoma[5]--;
            }
            else if (l == 6)
            {
                koma[a, b] = name_koma.fu;
                player2_motigoma[6]--;
            }
        }

        haiti();
        motigoma();




        Debug.Log(banmen[a, b]);
        Debug.Log(koma[a, b]);

        foreach (GameObject clone in selects)
        {
            Destroy(clone);
        }

        if (turn == player.player1)
        {
            Debug.Log("turn:player2");
            turn = player.player2;
        }
        else if (turn == player.player2)
        {
            Debug.Log("turn:player1");
            turn = player.player1;
        }
        yield break;
    }


    // Update is called once per frame
    void Update()
    {

        GameObject select = (GameObject)Resources.Load("select");
        GameObject clickedGameObject = null;



        if (Input.GetMouseButtonDown(0))
        {



            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D[] hits = Physics2D.RaycastAll((Vector2)ray.origin, (Vector2)ray.direction);

            //RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);



            /*if(hit2d)
            {
                 clickedGameObject = hit2d.transform.gameObject;
                 Debug.Log(clickedGameObject);
            }*/

            foreach (RaycastHit2D a in hits)
            {
                if (a.transform.name == "select(Clone)")
                {
                    clickedGameObject = a.transform.gameObject;
                    break;
                }
                else
                {
                    clickedGameObject = a.transform.gameObject;
                }
                Debug.Log(a.transform.name);
            }

        }

        GameObject click_koma = clickedGameObject;



        if (click_koma != null && click_koma.name != "yes" && click_koma.name != "no")
        {


            int a = click_koma.GetComponent<koma_here>().here[0];
            int b = click_koma.GetComponent<koma_here>().here[1];

            Debug.Log("a:" + a);
            Debug.Log("turn:" + turn);

            if (a > -1 && a < 9 && b > -1 && b < 9)
            {
                Debug.Log('b');
                if (click_koma.name != "select(Clone)")
                {
                    Debug.Log('c');
                    GameObject[] selects = GameObject.FindGameObjectsWithTag("select");


                    foreach (GameObject clone in selects)
                    {
                        Destroy(clone);
                    }
                    if (turn == banmen[a, b])
                    {
                        switch (koma[a, b])
                        {
                            case name_koma.gyoku:
                                gyoku_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("gyoku");
                                break;
                            case name_koma.hisha:
                                hisha_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("hisha");
                                break;
                            case name_koma.kaku:
                                kaku_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kaku");
                                break;
                            case name_koma.kin:
                                kin_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kin");
                                break;
                            case name_koma.nari_gin:
                                kin_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kin");
                                break;
                            case name_koma.nari_kei:
                                kin_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kin");
                                break;
                            case name_koma.nari_kyou:
                                kin_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kin");
                                break;
                            case name_koma.nari_fu:
                                kin_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kin");
                                break;
                            case name_koma.gin:
                                gin_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("gin");
                                break;
                            case name_koma.kei:
                                kei_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kei");
                                break;
                            case name_koma.kyou:
                                kyou_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kyou");
                                break;
                            case name_koma.fu:
                                fu_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("fu");
                                break;
                            case name_koma.ryuu:
                                Debug.Log(banmen[a, b]);
                                ryuu_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("ryuu");
                                break;
                            case name_koma.uma:
                                uma_move(a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("uma");
                                break;

                        }




                    }
                }
                else if (click_koma.name == "select(Clone)")
                {
                    Debug.Log("d");
                    StartCoroutine(select_select(a, b));
                }
            }
            else if (a == 9 && turn == player.player1)
            {

                GameObject[] selects = GameObject.FindGameObjectsWithTag("select");

                Debug.Log('B');
                selectkoma[0] = a;
                selectkoma[1] = b;

                foreach (GameObject clone in selects)
                {
                    Destroy(clone);
                }
                if (b != 6)
                {


                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (banmen[i, j] == 0)
                            {
                                Instantiate(select, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);

                            }
                        }
                    }
                }
                else if (b == 6)
                {

                    nifu();
                }
            }
            else if (a == 10 && turn == player.player2)
            {
                Debug.Log('C');
                GameObject[] selects = GameObject.FindGameObjectsWithTag("select");



                selectkoma[0] = a;
                selectkoma[1] = b;

                foreach (GameObject clone in selects)
                {
                    Destroy(clone);
                }

                if (b != 6)
                {


                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (banmen[i, j] == 0)
                            {
                                Instantiate(select, new Vector2(3.75f - j * (6.4f / 9f) + (6.4f / 18f), -3.3f + i * (6.4f / 9f) + (6.4f / 18f)), Quaternion.Euler(0, 0, 180f)).GetComponent<koma_here>().Here(i, j);

                            }
                        }
                    }
                }
                else if (b == 6)
                {
                    nifu();

                }
            }
        }

    }

}
