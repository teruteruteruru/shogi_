using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probability : MonoBehaviour
{

    public static void Probability_nari(int[] random_koma, int prob_ryuu, int prob_uma)
    {
        for (int i = 0; i < 100; i++)
        {
            if (i < prob_ryuu)
            {
                random_koma[i] = 1; //ryuu
            }
            if (i < (prob_ryuu + prob_uma) && i >= prob_ryuu)
            {
                random_koma[i] = 2; //uma
            }
            if (i >= (prob_ryuu + prob_uma))
            {
                random_koma[i] = 0; //kin
            }
        }
    }
}
