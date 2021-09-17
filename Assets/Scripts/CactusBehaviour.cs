using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusBehaviour : MonoBehaviour
{
    public GameObject cactusPefrab;
    public float respawnTimeMin,respawnTimeMax;
    public Transform spawnPosition;
    
    void Start()
    {
        StartCoroutine(cactoOnda());
    }
    
    IEnumerator cactoOnda()
    {
        while(true)
        {
            float i = Random.Range(respawnTimeMin,respawnTimeMax);
            yield return new WaitForSeconds(i);
            GameObject cacti = Instantiate(cactusPefrab,spawnPosition.position,spawnPosition.rotation);
        }
    }
}