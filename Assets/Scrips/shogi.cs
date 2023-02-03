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

//ゲームのメイン部分を担当しているクラス
public class Shogi : MonoBehaviour
{
    public player turn;
    
    public AudioClip sound1;
    public AudioClip sound2;

    


    private AudioSource _audioSource = null;



    [SerializeField] int probability_ryuu = 0;
    [SerializeField] int probability_uma = 0;


    private GameObject Winner;
    private GameObject click_koma;
    private player[,] banmen = new player[9, 9];   //駒の所有プレイヤーが入った配列
    private name_koma[,] koma = new name_koma[9, 9];　//駒の名前が入った配列
    private GameObject selectobj;
    private int[] player1_motigoma = new int[7];
    private int[] player2_motigoma = new int[7];

    private string winner_text;
    

    private int[] selectkoma = new int[2];
    private int[] random_koma = new int[100];
    public int random_koma_pub;

    


    //成る駒の確率をここで決める
    

    

    // Start is called before the first frame update
    void Start()
    {


        Winner = GameObject.Find("Winner");

        _audioSource = GetComponent<AudioSource>();

        //出てきた乱数の参照先
        Probability.Probability_nari(random_koma,probability_ryuu, probability_uma);
        
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

        //配列に初期状態を代入
        Initialization.Initialize(koma, banmen);

        //配置
        Arrangement.arrangement_ban(koma,banmen);

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
            GameObject _window = GameObject.Find("Window");
            _window.GetComponent<Window>().nari(0);
            bool isOK = _window.GetComponent<Window>().yes_no;
            bool isClicked = _window.GetComponent<Window>().isClicked;
            while (!isClicked)
            {
                isClicked = _window.GetComponent<Window>().isClicked;
                isOK = _window.GetComponent<Window>().yes_no;
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
            UnityEngine.Debug.Log("narikin");
            GameObject _window = GameObject.Find("Window");
            _window.GetComponent<Window>().nari(0);
            bool isOK = _window.GetComponent<Window>().yes_no;
            bool isClicked = _window.GetComponent<Window>().isClicked;
            while (!isClicked)
            {
                isClicked = _window.GetComponent<Window>().isClicked;
                isOK = _window.GetComponent<Window>().yes_no;
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
            UnityEngine.Debug.Log("narikin");
            GameObject _window = GameObject.Find("Window");
            _window.GetComponent<Window>().nari(0);
            bool isOK = _window.GetComponent<Window>().yes_no;
            bool isClicked = _window.GetComponent<Window>().isClicked;
            while (!isClicked)
            {
                isClicked = _window.GetComponent<Window>().isClicked;
                isOK = _window.GetComponent<Window>().yes_no;
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
            UnityEngine.Debug.Log("narikin");
            GameObject _window = GameObject.Find("Window");
            _window.GetComponent<Window>().nari(0);
            bool isOK = _window.GetComponent<Window>().yes_no;
            bool isClicked = _window.GetComponent<Window>().isClicked;
            while (!isClicked)
            {
                isClicked = _window.GetComponent<Window>().isClicked;
                isOK = _window.GetComponent<Window>().yes_no;
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
            UnityEngine.Debug.Log("narikin");
            GameObject _window = GameObject.Find("Window");
            _window.GetComponent<Window>().nari(0);
            bool isOK = _window.GetComponent<Window>().yes_no;
            bool isClicked = _window.GetComponent<Window>().isClicked;
            while (!isClicked)
            {
                isClicked = _window.GetComponent<Window>().isClicked;
                isOK = _window.GetComponent<Window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }

            if (isOK)
            {
                koma[a, b] = name_koma.ryuu;
                _audioSource.PlayOneShot(sound1);

            }

        }
        else if (a < 3 && turn == player.player2)
        {
            UnityEngine.Debug.Log("narikin");
            GameObject _window = GameObject.Find("Window");
            _window.GetComponent<Window>().nari(0);
            bool isOK = _window.GetComponent<Window>().yes_no;
            bool isClicked = _window.GetComponent<Window>().isClicked;
            while (!isClicked)
            {
                isClicked = _window.GetComponent<Window>().isClicked;
                isOK = _window.GetComponent<Window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }
            if (isOK)
            {
                koma[a, b] = name_koma.ryuu;
                _audioSource.PlayOneShot(sound1);

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
            UnityEngine.Debug.Log("narikin");
            GameObject _window = GameObject.Find("Window");
            _window.GetComponent<Window>().nari(0);
            bool isOK = _window.GetComponent<Window>().yes_no;
            bool isClicked = _window.GetComponent<Window>().isClicked;
            while (!isClicked)
            {
                isClicked = _window.GetComponent<Window>().isClicked;
                isOK = _window.GetComponent<Window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }

            if (isOK)
            {
                koma[a, b] = name_koma.uma;
                

            }


        }
        else if (a < 3 && turn == player.player2)
        {
            UnityEngine.Debug.Log("narikin");
            GameObject _window = GameObject.Find("Window");
            _window.GetComponent<Window>().nari(0);
            bool isOK = _window.GetComponent<Window>().yes_no;
            bool isClicked = _window.GetComponent<Window>().isClicked;
            while (!isClicked)
            {
                isClicked = _window.GetComponent<Window>().isClicked;
                isOK = _window.GetComponent<Window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
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
            UnityEngine.Debug.Log("narikin");
            GameObject _window = GameObject.Find("Window");
            _window.GetComponent<Window>().nari(0);
            bool isOK = _window.GetComponent<Window>().yes_no;
            bool isClicked = _window.GetComponent<Window>().isClicked;
            while (!isClicked)
            {
                isClicked = _window.GetComponent<Window>().isClicked;
                isOK = _window.GetComponent<Window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }

            if (isOK)
            {
                koma[a, b] = name_koma.uma;
                _audioSource.PlayOneShot(sound1);

            }


        }
        else if (a < 3 && turn == player.player2)
        {
            UnityEngine.Debug.Log("narikin");
            GameObject _window = GameObject.Find("Window");
            _window.GetComponent<Window>().nari(0);
            bool isOK = _window.GetComponent<Window>().yes_no;
            bool isClicked = _window.GetComponent<Window>().isClicked;
            while (!isClicked)
            {
                isClicked = _window.GetComponent<Window>().isClicked;
                isOK = _window.GetComponent<Window>().yes_no;
                Debug.Log(isClicked);
                UnityEngine.Debug.Log("isClicked:false");
                yield return null;
            }
            if (isOK)
            {
                koma[a, b] = name_koma.uma;
                _audioSource.PlayOneShot(sound1);

            }

        }

        yield break;

    }
    
    IEnumerator select_select(int a, int b)
    {

        Debug.Log("select");
        GameObject[] selects = GameObject.FindGameObjectsWithTag("select");
        GameObject[] komas = GameObject.FindGameObjectsWithTag("koma");
        _audioSource.PlayOneShot(sound2);
        if (banmen[a, b] != turn)
        {
            Getkoma.Get_koma(winner_text, turn, koma, player1_motigoma, player2_motigoma, a, b);
            Winner.GetComponent<Text>().text = winner_text;
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

        Arrangement.arrangement_ban(koma, banmen);
        Arrangement.arrangement_motigoma(player1_motigoma , player2_motigoma);




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
                                Koma_move.Gyoku_move(koma,banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("gyoku");
                                break;
                            case name_koma.hisha:
                                Koma_move.Hisha_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("hisha");
                                break;
                            case name_koma.kaku:
                                Koma_move.Kaku_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kaku");
                                break;
                            case name_koma.kin:
                                Koma_move.Kin_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kin");
                                break;
                            case name_koma.nari_gin:
                                Koma_move.Kin_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kin");
                                break;
                            case name_koma.nari_kei:
                                Koma_move.Kin_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kin");
                                break;
                            case name_koma.nari_kyou:
                                Koma_move.Kin_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kin");
                                break;
                            case name_koma.nari_fu:
                                Koma_move.Kin_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kin");
                                break;
                            case name_koma.gin:
                                Koma_move.Gin_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("gin");
                                break;
                            case name_koma.kei:
                                Koma_move.Kei_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kei");
                                break;
                            case name_koma.kyou:
                                Koma_move.Kyou_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("kyou");
                                break;
                            case name_koma.fu:
                                Koma_move.Fu_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("fu");
                                break;
                            case name_koma.ryuu:
                                Debug.Log(banmen[a, b]);
                                Koma_move.Ryuu_move(koma, banmen, a, b);
                                selectkoma[0] = a;
                                selectkoma[1] = b;
                                Debug.Log("ryuu");
                                break;
                            case name_koma.uma:
                                Koma_move.Uma_move(koma, banmen, a, b);
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
