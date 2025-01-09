using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystemUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI turnNumberText;
    [SerializeField] private Button endTurnButton;

    private void Start() {

        endTurnButton.onClick.AddListener(() => {
            TurnSystem.Instance.NexTurn();
        });

        TurnSystem.Instance.OnTurnChange += TurnSystem_OnTurnChange;
        
        UpdateTurnText();
    }

    private void UpdateTurnText() {
        turnNumberText.text = $"TURN {TurnSystem.Instance.GetTurnNumber()}";
    }

    private void TurnSystem_OnTurnChange(object sender, EventArgs e) {
        UpdateTurnText();
    }
}
