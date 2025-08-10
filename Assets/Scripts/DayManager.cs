using UnityEngine;

public class DayManager : MonoBehaviour
{
    [SerializeField] private LoadingScreen loadingScreen;

    public void SwitchDay(DayScreen prevDay, DayScreen nextDay)
    {
        loadingScreen.Black();
        if (prevDay)
            prevDay.gameObject.SetActive(false);
        nextDay.gameObject.SetActive(true);
        loadingScreen.FadeIn(nextDay.DayNumber);
    }
}
