using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ShowScore : MonoBehaviour
{
    HIT hiT;
    public TMPro.TextMeshPro ShowHit;
    public GameObject ScoreManager;
    // Start is called before the first frame update

    void Awake()
    {
        hiT = ScoreManager.GetComponent<HIT>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
