using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Window_color : MonoBehaviour
{

    public static Window_color instance;
    
    [SerializeField] Sprite rainbow;

    [SerializeField] GameObject window_image;

    

    public void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Window_coler_Red()
    {
        
        Color color = window_image.GetComponent<Image>().color;

        color.r = 1.0f;
        color.g = 0;
        color.b = 0;
        color.a = 0.1f;

        window_image.GetComponent<Image>().color = color;
    }

    public void Window_coler_Blue()
    {
        Color color = window_image.GetComponent<Image>().color;

        color.r = 0f;
        color.g = 0;
        color.b = 1.0f;
        color.a = 0.1f;

        window_image.GetComponent<Image>().color = color;
    }

    

    public void Window_coler_Rainbow()
    {
        
        Color color = window_image.GetComponent<Image>().color;

        color.r = 1.0f;
        color.g = 1.0f;
        color.b = 1.0f;
        color.a = 0.3f;

        window_image.GetComponent<Image>().color = color;
        window_image.GetComponent<Image>().sprite = rainbow;
    }





}
