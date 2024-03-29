using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    private int _amount;
    [SerializeField] private TMP_Text _scoreText;

    private void SetText()
    {
        _scoreText.text = _amount.ToString();
    }

    private void Start()
    {
        _amount = 0;
        SetText();
    }

    public void AddCoin()
    {
        _amount++;
        SetText();
    }
    public int GetAmount()
    {
        return _amount;
    }
}
