using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            SceneManager.LoadScene("PacMan");
        }

        if (Input.GetKeyDown(KeyCode.C)){
            SceneManager.LoadScene("StreetFighter2");
        }

        if (Input.GetKeyDown(KeyCode.B)){
            SceneManager.LoadScene("WarioLand3");
        }

        
    }
}
