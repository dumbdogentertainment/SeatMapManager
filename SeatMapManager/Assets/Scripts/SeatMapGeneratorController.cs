using UnityEngine;
using UnityEngine.UI;

public class SeatMapGeneratorController : MonoBehaviour
{
    #region Static Instance 
    public static SeatMapGeneratorController Instance = null;

    void Awake()
    {
        Instance = this;
    }

    void OnApplicationQuit()
    {
        Instance = null;
    }
    #endregion

    [SerializeField]
    private int rowsInFirst = 0;

    [SerializeField]
    private int rowsInBusiness = 0;

    [SerializeField]
    private int rowsInCoach = 0;

    public Transform MainCanvas;

    public void UpdateNumberOfRowsInFirstClass()
    {
        var rowsText = MainCanvas
            .Find("ConfigurationPanel")
            .Find("RowsInFirstInputField")
            .GetComponent<InputField>()
            .text;

        this.rowsInFirst = string.IsNullOrEmpty(rowsText) ?
            0 :
            int.Parse(rowsText);
    }

    public void UpdateNumberOfRowsInBusinessClass()
    {
        var rowsText = MainCanvas
            .Find("ConfigurationPanel")
            .Find("RowsInBusinessInputField")
            .GetComponent<InputField>()
            .text;

        this.rowsInBusiness = string.IsNullOrEmpty(rowsText) ?
            0 :
            int.Parse(rowsText);
    }

    public void UpdateNumberOfRowsInCoachClass()
    {
        var rowsText = MainCanvas
            .Find("ConfigurationPanel")
            .Find("RowsInCoachInputField")
            .GetComponent<InputField>()
            .text;

        this.rowsInCoach = string.IsNullOrEmpty(rowsText) ?
            0 :
            int.Parse(rowsText);
    }

    public void GenerateBaseSeatMap()
    {

    }
}