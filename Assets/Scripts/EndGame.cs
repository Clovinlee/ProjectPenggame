using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene(8);
            //CALVIN KWAN KERJA DISINI : WIN GAME, RETURN TO MAIN MENU BUTTON
            Debug.Log("YOU WIN!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
