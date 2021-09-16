using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pausar : MonoBehaviour
{
    [SerializeField] Image pausaT;
    [SerializeField] Image pausaF;
    public static bool pausa;
    public GameObject pauseMenuUI;
    
    void Start()
    {
        // if(!PlayerPrefs.HasKey("pausa"))
        // {
        //     PlayerPrefs.SetInt("pausa", 0);
        // }

        // else
        // {
        //     Load();
        // }

        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        if(pausa == false)
        {
            pausaT.enabled = true;
            pausaF.enabled = false;
        }

        else
        {
            pausaT.enabled = false;
            pausaF.enabled = true;
        }
    }
    
    public void OnButtonPress()
    {
        if(pausa == false)
        {
            pauseMenuUI.SetActive(true);
            pausa = true;
            Time.timeScale = 0f;
        }
        
        else
        {
            pauseMenuUI.SetActive(false);
            pausa = false;
            Time.timeScale = 1f;
        }

        //Save();
        UpdateButtonIcon();
    }

    // private void Load()
    // {
    //     pausa = PlayerPrefs.GetInt("pausa") == 1;
    // }

    // private void Save()
    // {
    //     PlayerPrefs.SetInt("pausa", pausa ? 1 : 0);
    // }
}