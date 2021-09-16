using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject palavra;
    [SerializeField]
    int maxt,mint;
    [SerializeField]
    List<Sprite> sprites;

    public List<Sprite> Sprites { get => sprites; set => sprites = value; }

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while(Sprites.Count >0)
        {
            yield return new WaitForSeconds(Random.Range(mint,maxt));
            int i = Random.Range(0,Sprites.Count);
            GameObject var =  Instantiate(palavra);
            var.GetComponent<Palavra>().ChangeSprite(Sprites[i]);
            var.GetComponent<Palavra>().Nome = Sprites[i].ToString();
        }
    }
}