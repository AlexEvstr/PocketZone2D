using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    [SerializeField] private Image _healthBar;
    [SerializeField] private GameObject _hitDetector;

    private int _totalHealth = 10000;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _totalHealth;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        EnemyHit();
    }

    private void EnemyHit()
    {
        if (_currentHealth > 0)
        {
            _currentHealth -= 10;

            _healthBar.fillAmount = _currentHealth / _totalHealth;

            Debug.Log($"{_currentHealth} / {_totalHealth}");

            if (_currentHealth == 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }
        
    }
}
