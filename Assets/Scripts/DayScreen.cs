using System;
using UnityEngine;

public class DayScreen : MonoBehaviour
{
    [SerializeField] private int dayNumber;
    private int countItems;
    [SerializeField] private GameObject botonScene;
    [SerializeField] private DialogSystem dialogSystem;
    [SerializeField] private DialogDataNoOpt InitialDialog;
    [SerializeField] private DialogDataNoOpt InterDialog;
    [SerializeField] private DialogDataNoOpt FinalDialog;

    public int DayNumber => dayNumber;

    internal void CompleteNoOptDialog()
    {
        if (countItems == 0)
        {
            botonScene.SetActive(true);
        }
    }

    internal void CompleteItem()
    {
        countItems--;

        if (countItems == 0)
        {
            if (FinalDialog)
                dialogSystem.ShowDialogNoOpt(FinalDialog);
            else
                botonScene.SetActive(true);
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
