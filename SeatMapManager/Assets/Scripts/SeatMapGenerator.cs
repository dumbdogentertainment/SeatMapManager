using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatMapGenerator : MonoBehaviour
{
    [SerializeField]
    private int NumberOfRows = 0;

    [SerializeField]
    private int NumberOfSeatsPerSeatbank = 0;

    public GameObject SeatTilePrefab;

    public float AisleOffset = 1f;
    public float RowSpacing = 1.25f;
    public float RowOffset = 1f;
    public float SeatSpacing = 1.25f;

    // Use this for initialization
    void Start()
    {
        for (int row = 0; row < this.NumberOfRows; row++)
        {
            this.SpawnRow(row);
        }
    }

    private void SpawnRow(int rowNumber)
    {
        this.SpawnSeatBank(rowNumber, -1);
        this.SpawnSeatBank(rowNumber, 1);
    }

    private void SpawnSeatBank(int rowNumber, int direction)
    {
        for (int seatIndex = 0; seatIndex < this.NumberOfSeatsPerSeatbank; seatIndex++)
        {
            Instantiate(
                this.SeatTilePrefab,
                new Vector3((this.RowOffset + rowNumber) * this.RowSpacing, direction * (this.AisleOffset + seatIndex) * this.SeatSpacing, 0),
                Quaternion.identity,
                this.transform);
        }
    }
}