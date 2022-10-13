using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_num : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine("random");
    }

    // Update is called once per frame
    IEnumerator random()
    {
        while (true)
        {
            num = 0;
            yield return new WaitForSeconds(0.4f);
            num = 1;
            yield return new WaitForSeconds(0.4f);
            num = 2;
            yield return new WaitForSeconds(0.4f);


        }
    }
    void Update()
    {
        
    }
}
