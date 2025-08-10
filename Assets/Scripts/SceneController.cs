using Coffee.UIEffects;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{

    [Header("Day")]
    [SerializeField] private DayManager dayManager;
    [SerializeField] private DayScreen dayOne;
    [SerializeField] private DayScreen dayTwo;
    [SerializeField] private DayScreen dayThreeMatrix;
    [Header("otros")]
    [SerializeField] private DayScreen dayThreeDellu;
    [SerializeField] private InfoStoragePlaer infoStoragePlaer;
    [SerializeField] private int pointsForDayThreeMatrix;
    [SerializeField] private Image finImageM;
    [SerializeField] private Image finImageD;

    private DayScreen currentDay;

    private void Awake()
    {
        //finImageM = GetComponent<Image>();
        //finImageM.enabled = false;
        //finImageD = GetComponent<Image>();
        //finImageD.enabled = false;
        dayOne.gameObject.SetActive(false);
        dayTwo.gameObject.SetActive(false);
        dayThreeMatrix.gameObject.SetActive(false);
        dayThreeDellu.gameObject.SetActive(false);
        dayManager.SwitchDay(null, dayOne);
        currentDay = dayOne;
    }

    public void OnButtonPressed()
    {
        if (currentDay == dayOne)
        {
            dayManager.SwitchDay(dayOne, dayTwo);
            currentDay = dayTwo;
        }
        else if (currentDay == dayTwo)
        {
            if (infoStoragePlaer.totalPoints >= pointsForDayThreeMatrix)
            {
                dayManager.SwitchDay(dayTwo, dayThreeMatrix);
                currentDay = dayThreeMatrix;

            }
            else
            {
                dayManager.SwitchDay(dayTwo, dayThreeDellu);
                currentDay = dayThreeDellu;
            }
        }
        else
        {
            SceneManager.LoadScene("MenuScene");
        }
    }

    internal void CompleteCurrentDayItem(bool isNoOptDialog)
    {
        if (isNoOptDialog)
            currentDay.CompleteNoOptDialog();
        else
            currentDay.CompleteItem();
    }
}