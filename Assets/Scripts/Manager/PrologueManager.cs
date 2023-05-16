
using UnityEngine;
using UnityEngine.SceneManagement;
public class PrologueManager : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }
    }
}
