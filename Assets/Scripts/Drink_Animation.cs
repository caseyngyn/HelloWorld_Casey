using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink_Animation : MonoBehaviour
{
    [SerializeField] public Animator animator;
    public float bac = 0;


    // addressing animation on hand
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.gameObject.tag);
        //collision.collider will be the cup
        if (collision.collider.gameObject.tag == "HasBall")
        {
            bac = 20;
            Debug.Log("Object enter the cup");
            animator.SetFloat("BAC_levels", bac);
            collision.collider.gameObject.tag = "Cup";
        }
    }

    private void Update()
    {
        bac -= Time.deltaTime;
        animator.SetFloat("BAC_levels", bac);
    }

}
