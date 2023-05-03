
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingBar : MonoBehaviour
{
 private Slider timer_sl;

    float time_remain;
    public float time_max = 5.0f;


    void Awake()
    {
        timer_sl = gameObject.GetComponent<Slider>();
    }

    void Start()
    {
        time_remain = 0;
    }


    void Update()
    {
        if (time_remain < time_max)
        {
            time_remain += Time.deltaTime;
            timer_sl.value = time_remain/time_max;
        }
        else
        {
            SceneManager.LoadScene(1);
        }    
    }
}
