using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Window_color_Random : MonoBehaviour
{
    public static Window_color_Random instance;

    [SerializeField] int red_probability = 0;
    [SerializeField] int rainbow_probability = 0;
    


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    

    public void Color_Randomizer()
    {
        int ramdom_windowcolor = UnityEngine.Random.Range(0, 100);
        Debug.Log("windowcolor="+ramdom_windowcolor);
        if (ramdom_windowcolor<red_probability)
        {
            UnityEngine.Debug.Log("Red");
            Window_color.instance.Window_coler_Red();
        }
        else if(ramdom_windowcolor > red_probability && ramdom_windowcolor < rainbow_probability + red_probability)
        {
            UnityEngine.Debug.Log("Rainbow");
            Window_color.instance.Window_coler_Rainbow();
            
        }
        else if (ramdom_windowcolor > rainbow_probability + red_probability)
        {
            UnityEngine.Debug.Log("Blue");
            Window_color.instance.Window_coler_Blue();
        }
    }
}
