using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public float shakeDuration;
    public float shakeMagnitude;
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
        if(other.gameObject.CompareTag("Boss")){
            cameraShake.Instance.ShakeCamera(shakeMagnitude, 999);
        }
    }
    
    /// <summary>
    /// Sent when another object leaves a trigger collider attached to
    /// this object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Boss")){
            cameraShake.Instance.ShakeCamera(0f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
