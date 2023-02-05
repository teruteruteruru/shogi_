using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_sound : MonoBehaviour
{

    public static Play_sound instance;
    public AudioClip sound_kyuin;

    private AudioSource _audioSource = null;

    [SerializeField] int sound_probability = 0;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Random_sound()
    {
        int random_sound = UnityEngine.Random.Range(0, 100);
        if (random_sound < sound_probability)
        {
            _audioSource.PlayOneShot(sound_kyuin);
        }
    }
   
}
