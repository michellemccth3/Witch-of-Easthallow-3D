using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float health = 5;
    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Slime" || collision.gameObject.tag == "Robot")
        {
            health -= 5*Time.deltaTime;
            print(health);
        }
        
    }

    void Update()
    {
        if(health <= 0)
        {
            Time.timeScale = 0;
            //pauseMenu.SetActive(true);
            SceneManager.LoadScene("Main Menu");
        }
        if(GameObject.FindGameObjectsWithTag("Slime").Length == 0 && GameObject.FindGameObjectsWithTag("Robot").Length == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
