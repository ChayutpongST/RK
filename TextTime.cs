using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextTime : MonoBehaviour
{
    float time = 70;
    TextMeshProUGUI textMeshPro;
    public GameObject Score;
    public GameObject AllScore;
    public GameObject AllMiss;
    public GameObject AllCombob;
    public GameObject panel;
    public GameObject Overall;
    public GameObject Tim;
    public GameObject SongName;
    public GameObject ScoreName;
    public GameObject MissName;
    public GameObject Diff;
    public GameObject ComboName;




    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        showMenu();
        AllScore.SetActive(true);
        AllMiss.SetActive(true);
        AllCombob.SetActive(true);
        panel.SetActive(false);
        Overall.SetActive(true);
        Tim.SetActive(true);
        Score.SetActive(false);
        SongName.SetActive(true);
        ScoreName.SetActive(true);
        MissName.SetActive(true);
        Diff.SetActive(true);
        ComboName.SetActive(true);




        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            textMeshPro.text = string.Format("Time : {0:#}", time);
        }
        else
        {
            showMenu();
        }
    }
    public void showMenu()
    {
        panel.SetActive(true);
        Time.timeScale = 1;
        AllScore.SetActive(false);
        AllMiss.SetActive(false);
        AllCombob.SetActive(false);
        Overall.SetActive(false);
        Tim.SetActive(false);
        Score.SetActive(true);
        SongName.SetActive(false);
        ScoreName.SetActive(false);
        MissName.SetActive(false);
        Diff.SetActive(false);
        ComboName.SetActive(false);




    }
    public void hideMenu()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
