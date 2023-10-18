using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShootButton : MonoBehaviour
{
    [SerializeField] private TMP_Text _ammoText;

    private int _maxAmmo = 40;
    private int _currentAmmo = 40;

    private void Start()
    {
        _ammoText.text = $"{_currentAmmo} / {_maxAmmo}";
    }

    public void Shoot()
    {
        if (_currentAmmo != 0 && EnemyDetector._canShoot)
        {
            _currentAmmo--;
            _ammoText.text = $"{_currentAmmo} / {_maxAmmo}";
        }

    }
}
