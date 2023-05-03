using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    [Header("VisualCue")] //Hint "E" button

    [SerializeField] private GameObject VisualCue;

    [Header("Ink JSON")] //Dialogue text
    [SerializeField] private TextAsset inkJson;

    private bool PlayerInRange; //Player in NPC collider
    
    void Awake()
    {
        VisualCue.SetActive(false);
        PlayerInRange = false;
    }

    private void Update() 
    {
        if(PlayerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            VisualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJson);
            }
        }    
        else
        {
            VisualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider2D) 
    {
        if (collider2D.gameObject.tag == "Player")
        {
            PlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Player")
        {
            PlayerInRange = false;
        }
    }
    
}
