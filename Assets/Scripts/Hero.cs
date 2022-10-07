using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Hero : MonoBehaviour
{
    public bool hasAxe = false;
    public TMP_Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AxeGet(){
        hasAxe=true;
        txt.text="Look, an axe! Could be useful!";
        StartCoroutine(RemoveText());
    }
    public void TreeChopped(){
        txt.text="Great!! The road's clear now";
        StartCoroutine(RemoveText());
    }
    public IEnumerator RemoveText(){
        yield return new WaitForSeconds(5);
        txt.text="";
    }
}
