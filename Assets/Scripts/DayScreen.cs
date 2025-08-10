using System;
using UnityEngine;

public class DayScreen : MonoBehaviour
{
    [SerializeField] private int dayNumber;
    private int countItems;
    [SerializeField] private GameObject botonScene;

    public int DayNumber => dayNumber;

    internal void CompleteItem()
    {
        countItems--;
        if (countItems == 0)
        {
            botonScene.SetActive(true);
            Debug.Log("Se activo");
        }
    }

    private void Awake()
    {
        countItems = GetComponentsInChildren<Item>(true).Length;
    }

    private void OnEnable()
    {
        botonScene.gameObject.SetActive(false);
        Debug.Log("se desactivo");
    }
}
