using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bossCollision : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float moveSpeed;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")){
            Animator anim = other.gameObject.GetComponent<Animator>();
            if(anim.GetBool("isDied") == false){
                anim.SetBool("isRunning",false);
                anim.SetBool("isDied",true);
                anim.Play("die");
                StartCoroutine(gameOver());
            }
        }else{
            if(other.gameObject.CompareTag("TreeObstacle")){
                StartCoroutine(bossDisappear(gameObject));
            }
        }
    }

    IEnumerator bossDisappear(GameObject boss){
        yield return new WaitForSeconds(5);

        Destroy(boss);
    }

    IEnumerator gameOver(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(7);
        //CALVIN KWAN KERJA INI : YOU DIED SCRIPT KWAN KERJA INI
        Debug.Log("YOU DIED");
        //
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
