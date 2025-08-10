using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Button))]
public class Item : MonoBehaviour
{
    private Button button;
    [SerializeField] private DialogSystem dialogSystem;
    [SerializeField] private DialogData data;

    private void Awake()
    {
        button = GetComponent<Button>();
    }
    private void Start()
    {
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        dialogSystem.ShowDialog(data);
        button.interactable = false;
    }


}