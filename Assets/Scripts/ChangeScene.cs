using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string nomeCena;
    public void ChangeS()
    {
        SceneManager.LoadScene(nomeCena);
    }
    public void Sair()
    {
        Application.Quit();
    }
}