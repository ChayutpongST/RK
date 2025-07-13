using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HIT : MonoBehaviour
{
    float time1 = 71;
    public static HIT Instance;
    public static float combo;
    public GameObject perfect;
    public GameObject good;


    public TMPro.TextMeshPro comboText;
    public TextMeshProUGUI ShowHit;
    
    // Start is called before the first frame update
    void Start()
    {
        

        Instance = this;
        combo = 0;
        perfect.SetActive(false);
       good.SetActive(false);
        Time.timeScale = 1;
    }
    public static void Hit()
    {
        combo += 1;
        

    }

    private void Update()
    {
        
        comboText.text = combo.ToString();
        ShowHit.text = combo.ToString();
        

        if (time1 >= 0)
        {
            time1 -= Time.deltaTime;
            if (combo == 54)
            {
                perfect.SetActive(true);
            }
            else
            {
                good.SetActive(true);
            }
        }

    }
    
}
