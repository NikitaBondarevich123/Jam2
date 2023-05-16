using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HappyEnd : MonoBehaviour
{
    [SerializeField] private GameObject HappyPanel;
    private bool PlayerInRange;
    void Awake()
    {
        HappyPanel.SetActive(false);
        PlayerInRange = false;
    }

    
    void Update()
    {
        if (PlayerInRange)
        {
            
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(7);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider2D) 
    {
        if (collider2D.gameObject.tag == "Player")
        {
            PlayerInRange = true;
            HappyPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Player")
        {
            PlayerInRange = false;
            HappyPanel.SetActive(false);
        }
    }
}
