using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        GameObject p = other.gameObject;
        if(p.CompareTag("Player")){
            p.GetComponent<Hero>().hasAxe = true;
            gameObject.SetActive(false);
            //CALVIN KWAN KERJA INI : KWAN MUNCULNO TEKS AKU DAPAT AXE, I WONDER WHAT THIS USE BLALBA
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
