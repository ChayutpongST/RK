using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public AudioSource hitSFX;
    public AudioSource missSFX;
    public TMPro.TextMeshPro scoreText;
    public TMPro.TextMeshPro OverAllScore;
    public TextMeshProUGUI OverALL;
    public static int scoreM;
    static int comboScore;
    


    public float hit;
    public float miss;
    void Start()
    {
        Instance = this;
        comboScore = 0;
        scoreM = 0;
    }
    public static void Hit()
    {
        comboScore += 1;
        scoreM += 500*comboScore;
        Instance.hitSFX.Play();
        
    }

    public static void Miss()
    {
        comboScore = 0;
        Instance.missSFX.Play();
    }
    
    public void Update()
    {
        
        scoreText.text = comboScore.ToString();
        OverAllScore.text = scoreM.ToString();
        OverALL.text = scoreM.ToString();
    }
}
