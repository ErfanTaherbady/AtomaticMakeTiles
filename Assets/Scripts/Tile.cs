using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Tile : MonoBehaviour
{
    [Header("UI Refrense")]
    [SerializeField] private TextMeshProUGUI numberClickedText;

    private int currentCliked;
    private void Start()
    {
        FirstRefrenses();
    }
    private void FirstRefrenses()
    {
        currentCliked = 0;
        UpdateUI();
    }
   
    private void OnMouseDown()
    {
        currentCliked++;
        UpdateUI();
    }
    private void UpdateUI()
    {
        numberClickedText.text = currentCliked.ToString();
    }
}
