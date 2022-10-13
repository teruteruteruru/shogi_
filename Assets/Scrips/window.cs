using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class window : MonoBehaviour
{
    public bool yes_no;
    public bool isClicked;
    private GameObject yes;
    
    private GameObject no;
   
    private GameObject window_image;
    private GameObject windowtext;
    private string buttom = "aaa";
    private GameObject obj1;
    private GameObject obj2;
    private GameObject clickedGameObject;
    void Start() 
    {
        window_image = GameObject.Find("window_image");
        Debug.Log(window_image);
        window_image.GetComponent<Image>().enabled = false;
    }

    public void nari(int a)
    {
        yes = (GameObject)Resources.Load("yes");
        obj1 = Instantiate(yes, new Vector3(-1.0f, -1.0f, -5.0f), Quaternion.identity) as GameObject;
        obj1.name = "yes";


        no = (GameObject)Resources.Load("no");
        obj2 = Instantiate(no, new Vector3(3.0f, -1.0f, -5.0f), Quaternion.identity) as GameObject;
        obj2.name = "no";


       
        window_image = GameObject.Find("window_image");
        window_image.GetComponent<Image>().enabled = true;
       
        
       

        Debug.Log("aaaaa");
        isClicked = false;
        buttom = " ";
        Debug.Log("isClicked:" + isClicked);
        StartCoroutine(wait(a));
        
        
    }
    IEnumerator wait(int a) 
    {
        int num;
        yield return new WaitForSeconds(0.1f);
        Debug.Log("isClicked:" + isClicked);
        Debug.Log(buttom); 
        windowtext = GameObject.Find("windowtext");
        var Ran_Obj = GameObject.Find("Random_num");
        string[] nari_text_random = new string[3];
        nari_text_random[0] = "‹à‚É‚È‚è‚Ü‚·";
        nari_text_random[1] = "<color=#8b0000>—´‰¤</color>‚É‚È‚è‚Ü‚·";
        nari_text_random[2] = "<color=#00008b>—´”n</color>‚É‚È‚è‚Ü‚·";
        while (!isClicked)
        {
            if (a == 0)
            {
                num = Ran_Obj.GetComponent<Random_num>().num;
            }else
            {
                num = a;
            }
            clickedGameObject = GameObject.Find("Enpty");
            windowtext.GetComponent<Text>().text = nari_text_random[num];
            
            if (Input.GetMouseButtonDown(0))
            {



                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);


                if (hit2d)
                {
                    clickedGameObject = hit2d.transform.gameObject;
                }


            }
            buttom = clickedGameObject.name;
            
            




            if (buttom == "yes")
            {
                Debug.Log(buttom);
                isClicked = true;
                windowtext = GameObject.Find("windowtext");
                Debug.Log(windowtext);
                yes_no = true;
                Destroy(obj1);
                Destroy(obj2);
                Debug.Log(windowtext);
                window_image = GameObject.Find("window_image");
                Debug.Log(window_image.GetComponent<Image>());
                window_image.GetComponent<Image>().enabled = false;
                windowtext.GetComponent<Text>().text = "";
            }
            if (buttom == "no")
            {
                Debug.Log(buttom);
                isClicked = true;
                windowtext = GameObject.Find("windowtext");
                Debug.Log(windowtext);
                yes_no = false;
                Destroy(obj1);
                Destroy(obj2);
                Debug.Log(windowtext);
                window_image = GameObject.Find("window_image");
                Debug.Log(window_image.GetComponent<Image>());
                window_image.GetComponent<Image>().enabled = false;
                windowtext.GetComponent<Text>().text = "";
            }
            yield return null;
        }
        
        yield break;

    }
}

    

