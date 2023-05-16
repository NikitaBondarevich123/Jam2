using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StaminaBar : MonoBehaviour
{
    private Slider timer_sl;

    float time_remain;
    public float time_max = 5.0f;

    public AudioClip sound;

    void Awake()
    {
        timer_sl = gameObject.GetComponent<Slider>();
    }

    void Start()
    {
        time_remain = time_max;
    }


    void Update()
    {
        if (time_remain > 0)
        {
            time_remain -= Time.deltaTime;
            timer_sl.value = time_remain/time_max;
        }
        else
        {
            SceneManager.LoadScene(3);
        }    
    }

    public void Restaminization()
    {
        timer_sl.value = 1;
        time_remain = time_max;
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}
