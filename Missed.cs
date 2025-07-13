using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Missed : MonoBehaviour
{
    public static Missed Instance;
    static float miss;
    public TMPro.TextMeshPro missText;
    public TextMeshProUGUI ShowMiss;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        miss = 0;
    }
    public static void Miss()
    {
        miss += 1;


    }

    // Update is called once per frame
    private void Update()
    {
        missText.text = miss.ToString();
        ShowMiss.text = miss.ToString();
        //if (miss == 4)
        //{
         //   SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       // }
    }
}
