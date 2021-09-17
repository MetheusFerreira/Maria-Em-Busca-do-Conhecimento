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
        UpdateButtonIcon();
    }
}