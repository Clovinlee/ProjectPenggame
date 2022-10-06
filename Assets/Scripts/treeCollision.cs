using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player")){
            Hero h = other.gameObject.GetComponent<Hero>();
            if(h.hasAxe){
                gameObject.SetActive(false);
                // KWAN KERJA INI J
                // MUNCULNO teks tree has ben chopped apalah tsb.
            }else{
                // KWAN KERJA INI
                // MUNCULKAN TEKS AKu butuh axe
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
