using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    [Header("Contexto")]
    public TMP_Text context;
    [Header("option A")]
    public Button botonA;
    public TMP_Text textA;
    [Header("option B")]
    public Button botonB;
    public TMP_Text textB;
    [Header("DATA")]
    DialogData data;
    DialogDataNoOpt dataNoOpt;
    [Header("otros")]
    public Button botonNext;
    public InfoStoragePlaer infoStorage;
    
    private int nextLineIndex;
    private string[] currentLines;
    private bool shouldDisableOnFinish;
    private bool isNoOptDialog;

    [SerializeField] private SceneController botonScene;

    private void Awake()
    {
        gameObject.SetActive(false);
    }
    private void Start()
    {
        if (dataNoOpt != null)
        {
            ShowDialogNoOpt(dataNoOpt);

        }
    }

    public void ShowDialog(DialogData inData)
    {
        gameObject.SetActive(true);
        isNoOptDialog = false;
        data = inData;
        textA.text = data.optA;
        textB.text = data.optB;
        StartLinesArray(data.context, false);
    }
    public void OnButtonAClicked()
    {
        
        StartLinesArray(data.conversationA, true);
        infoStorage.AddPoints(data.scoreA);

    }
    public void OnButtonBClicked()
    {
        
        StartLinesArray(data.conversationB, true);
        infoStorage.AddPoints(data.scoreB);
    }
    public void ShowDialogNoOpt(DialogDataNoOpt inData)
    {
        gameObject.SetActive(true);
        isNoOptDialog = true;
        dataNoOpt = inData;

        // Ocultar permanentemente botones A y B
        botonA.gameObject.SetActive(false);
        botonB.gameObject.SetActive(false);

        StartLinesArray(dataNoOpt.context, true);
    }


    private void StartLinesArray(string[] linesArray, bool shouldDisableOnFinish)
    {
        botonA.gameObject.SetActive(false);
        botonB.gameObject.SetActive(false);
        botonNext.gameObject.SetActive(true);

        nextLineIndex = 0;
        currentLines = linesArray;
        this.shouldDisableOnFinish = shouldDisableOnFinish;
        OnNextClicked();
    }

    public void OnNextClicked()
    {
        if (shouldDisableOnFinish && nextLineIndex == currentLines.Length)
        {
            gameObject.SetActive(false);
            botonScene.CompleteCurrentDayItem(isNoOptDialog);
            return;
        }

        context.text = currentLines[nextLineIndex];
        nextLineIndex++;

        if (!shouldDisableOnFinish && nextLineIndex == currentLines.Length)
        {
            botonA.gameObject.SetActive(true);
            botonB.gameObject.SetActive(true);
            botonNext.gameObject.SetActive(false);
        }
    }
}
