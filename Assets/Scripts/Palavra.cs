using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palavra : MonoBehaviour
{
    [SerializeField]
    string nome;
    SpriteRenderer opa;
    public string Nome{get;set;}
    public SpriteRenderer Opa{get;set;}
    
    void start()
    {
        Opa = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        transform.position -= new Vector3(0.1f,0f,0f);
    }
}
