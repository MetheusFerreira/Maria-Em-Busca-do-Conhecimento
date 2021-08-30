using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deploy : MonoBehaviour
{
    public GameObject cactusPefrab;
    public float respawnTime = 1f;
    private Vector2 screenBounds;
    
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(cactoOnda());
    }
    
    private void SpawnEnemy()
    {
        GameObject cacti = Instantiate(cactusPefrab) as GameObject;
        cacti.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
   
   IEnumerator cactoOnda()
   {
       while(true)
       {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
       }
   }
}
