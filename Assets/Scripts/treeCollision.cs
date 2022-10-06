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
        Debug.Log("SOmething Entered");
        if(other.gameObject.CompareTag("Player")){
            Hero h = other.gameObject.GetComponent<Hero>();
            if(h.hasAxe){
                gameObject.SetActive(false);
            }else{
                // KWAN KERJA INI
                // MUNCULKAN TEKS AKu butuh axe
            }

        }else if(other.gameObject.CompareTag("Boss")){
            Debug.Log("DETECTED COLLISION");
            StartCoroutine(bossDisappear(other.gameObject));
        }
    }

    IEnumerator bossDisappear(GameObject boss){
        Debug.Log("COROUTINE BEGUN");
        yield return new WaitForSeconds(5);

        Debug.Log("COROUTINE ENDED");
        //YOU DIED SCRIPT
        Destroy(boss);
        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
