using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private TMP_Text _healthText;
    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
        SetText();
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;
        SetText();
        if (_currentHealth <= 0) 
            Die();
    }

    private void SetText()
    {
        _healthText.text = _currentHealth.ToString();
    }
}
