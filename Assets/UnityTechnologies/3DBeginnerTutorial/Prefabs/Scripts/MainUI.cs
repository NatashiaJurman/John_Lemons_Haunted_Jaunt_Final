using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUI : MonoBehaviour
{
    public float totalTime = 120f;
    public TextMeshProUGUI timerText;

    public GameObject blankFrame;
    public GameObject sprintFrame;

    private bool isSprinting;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Major Mod Timer UI
        Timer();
        SprintUI();
    }

    void Timer()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
        }

        else
        {
            totalTime = 0;
        }

        int seconds = Mathf.FloorToInt(totalTime);
        timerText.text = string.Format("{00}", seconds);
    }

    void SprintUI()
    {
        if (isSprinting == true)
        {
            sprintFrame.SetActive(true);
            blankFrame.SetActive(false);
        }

        else if (isSprinting == false) 
        {
            sprintFrame.SetActive(false);
            blankFrame.SetActive(true);
        }
    }


}
