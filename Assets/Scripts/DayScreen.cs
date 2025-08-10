using System;
using UnityEngine;
using UnityEngine.UI;

public class DayScreen : MonoBehaviour
{
    [SerializeField] private int dayNumber;
    private int countItems;
    [SerializeField] private GameObject botonScene;
    [SerializeField] private DialogSystem dialogSystem;
    [SerializeField] private DialogDataNoOpt InitialDialog;
    [SerializeField] private DialogDataNoOpt InterDialog;
    [SerializeField] private DialogDataNoOpt FinalDialog;
    [SerializeField] private Image finImage;

    public int DayNumber => dayNumber;

    internal void CompleteNoOptDialog()
    {
        if (countItems == 0)
        {
            SetRedyForNextDay();
        }
    }

    private void SetRedyForNextDay()
    {
        botonScene.SetActive(true);
        if (finImage)
            finImage.gameObject.SetActive(true);
    }

    internal void CompleteItem()
    {
        countItems--;

        if (countItems == 0)
        {
            if (FinalDialog)
                dialogSystem.ShowDialogNoOpt(FinalDialog);
            else
                SetRedyForNextDay();
            Debug.Log("Se activo");
        }
        else if (countItems == 1)
        {
            if (InterDialog)
                dialogSystem.ShowDialogNoOpt(InterDialog);
        }
    }

    private void Awake()
    {
        if (finImage)
            finImage.gameObject.SetActive(false);
        countItems = GetComponentsInChildren<Item>(true).Length;
    }

    private void OnEnable()
    {
        if (InitialDialog)
        {

            dialogSystem.ShowDialogNoOpt(InitialDialog);

        }
        
            botonScene.gameObject.SetActive(false);
        Debug.Log("se desactivo");
    }
}
