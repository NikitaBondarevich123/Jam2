using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ProgressBar : MonoBehaviour

{

    private Slider slider; 

    public float val;
    public AudioClip sound;
    

    private  void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        
    }

    private void Update()
    {
        if (slider.value == 1)
        {
            SceneManager.LoadScene(5);
        }
    }
 
    public void Progress()
    {

        slider.value += val;
        AudioSource.PlayClipAtPoint(sound, transform.position);

        
        
    }
    

}
