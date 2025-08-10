using Coffee.UIEffects;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BotonScene : MonoBehaviour
{
    [SerializeField] private DayManager dayManager;
    [SerializeField] private DayScreen dayOne;
    [SerializeField] private DayScreen dayTwo;
    [SerializeField] private DayScreen dayThreeMatrix;
    [SerializeField] private DayScreen dayThreeDellu;
    [SerializeField] private InfoStoragePlaer infoStoragePlaer;
    [SerializeField] private int pointsForDayThreeMatrix;

    private DayScreen currentDay;

    private void Awake()
    {
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

    internal void CompleteCurrentDayItem()
    {
        currentDay.CompleteItem();
    }
}