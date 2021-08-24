using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMovements : MonoBehaviour
{
    public Maria movement;
    public GameObject gameOverUI;
    public static bool gamePausado;
    
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gamePausado = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "cactus")
        {
            movement.enabled = false;
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
            gamePausado = true;
        }
        Debug.Log("sussy baka");
    }
}
