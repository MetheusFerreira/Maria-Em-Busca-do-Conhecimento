using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    [SerializeField]
    string nome;
    SpriteRenderer opa;
    public string Nome{get;set;}
    public SpriteRenderer Opa{get;set;}
    
    void Start()
    {
        Opa = GetComponent<SpriteRenderer>();
        Destroy(this.gameObject, 10f);
    }
    void FixedUpdate()
    {
        transform.position -= new Vector3(0.6f,0f,0f);
    }
    public void ChangeSprite(Sprite uepa)
    {
        GetComponent<SpriteRenderer>().sprite = uepa;
    }
}
