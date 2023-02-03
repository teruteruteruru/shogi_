using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public static float row_zero = 3.75f;
    public static float column_zero = -3.3f;
    public static float ban_length = 6.4f;
    public static float cell_number = 9f;
    public static float direction_player1 = 0f;
    public static float direction_player2 = 180f;
    public static float motigoma_player1_x = 6f;
    public static float motigoma_player1_y = 0f;
    public static float motigoma_player2_x = -6f;
    public static float motigoma_player2_y = 0.3f;
    public static float length_motigoma = 0.3f;

    



    //ãÓÇÉNÉçÅ[ÉìÇ∑ÇÈ
    public static void Instantiate_koma(GameObject koma, int i, int j, float direction)
    {
        Instantiate(koma, new Vector2(row_zero - j * (ban_length / cell_number) + (ban_length / (2f * cell_number)), column_zero + i * (ban_length / cell_number) + (ban_length / (2f * cell_number))), Quaternion.Euler(0, 0, direction)).GetComponent<koma_here>().Here(i, j);
    }
    
}
