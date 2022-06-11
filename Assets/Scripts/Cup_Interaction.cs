using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup_Interaction : MonoBehaviour
{
    [SerializeField] public Animator animator;
    public float bac = 0;
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bac -= Time.deltaTime;
        animator.SetFloat("BAC_levels", bac);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(gameObject.tag == "HasBall")
        {
            animator.SetFloat("BAC_levels", 20);
        }
    }
}


//IDK it's not working sry