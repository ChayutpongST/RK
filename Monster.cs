using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Monster : MonoBehaviour
{
    public static Monster Instance;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    public static void Hit()
    {
        Instance.anim.Play("Base2Dead");
    }
    void Update()
    {
       
    }
}
