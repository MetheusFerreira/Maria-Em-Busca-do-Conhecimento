using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image fillBar;
    public int health;

    public void LoseHealth(int value)
    {
        if (health <= 0)
        {
            return;
        }
        
        health -= value;
        fillBar.fillAmount = health / 100;
        if(health<=0)
        {
            Debug.Log("YOU MORREU");
        }
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            LoseHealth(25);
        }
    }
}
