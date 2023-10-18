using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class EnemyHP : MonoBehaviour
{
    [SerializeField] private Image _healthBar;
    [SerializeField] private GameObject _enemy;
    private float xPosition;
    private int yPosition;

    private int _totalHealth = 100;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _totalHealth;
    }

    public void HPdecrease()
    {
        
        if (_currentHealth > 0)
        {
            _currentHealth -= 10;

            _healthBar.fillAmount = _currentHealth / _totalHealth;

            Debug.Log($"{_currentHealth} / {_totalHealth}");

            if (_currentHealth == 0)
            {
                xPosition = Random.Range(-595, -576);
                _enemy.transform.position = new Vector2(_enemy.transform.position.x + 20, yPosition);
                _currentHealth = 100;
                _healthBar.fillAmount = 1;
            }
        }
    }
}
