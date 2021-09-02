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
        StartCoroutine(cactoOnda());
    }
    
    private void SpawnEnemy()
    {
        GameObject cacti = Instantiate(cactusPefrab) as GameObject;
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
