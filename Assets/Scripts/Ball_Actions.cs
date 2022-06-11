using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Actions : MonoBehaviour
{

    public Transform reset;
    public GameObject trigger;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        
        if (collider.gameObject.CompareTag("Cup"))
        {
            Debug.Log("Object enter the trigger");
            this.transform.position = reset.position;
            collider.gameObject.tag = "HasBall";
            Debug.Log("Ball "+collider.gameObject.tag);
            trigger.SetActive(true);
        }


    }
}
