using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")){
            Animator anim = other.gameObject.GetComponent<Animator>();
            if(anim.GetBool("isDied") == false){
                anim.SetBool("isRunning",false);
                anim.SetBool("isDied",true);
                anim.Play("die");
                gameOver();
            }
        }else{
            Debug.Log("Sus from boss");
        }
    }

    IEnumerator gameOver(){
        yield return new WaitForSeconds(3);
        
        //YOU DIED SCRIPT KWAN KERJA INI
        Debug.Log("YOU DIED");
        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
