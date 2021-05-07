using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1: MonoBehaviour
{
    [SerializeField] private Health _target;

    private Image _hpBar;

    private float _maxHp;
    private float _currentHp;

    private void Awake()
    {
        _hpBar = GetComponent<Image>();
        _currentHp = _maxHp;

        SubscribeToEvents();
    }

    private void SubscribeToEvents()
    {
        _target.SetMaxHpEvent += SetMaxHp;

        _target.ApplyDamageEvent += Display;
        _target.RegenerationEvent += Display;

        _target.DeathEvent += OnDeath;
    }

    private void Display(float hp)
    {
        _hpBar.fillAmount = _target.CurrentHp / _maxHp;
    }

    private void OnDeath()
    {
        _hpBar.fillAmount = 0;
        Debug.LogWarning(_target.CurrentHp);
    }

    private void SetMaxHp(float hp)
    {
        _maxHp = hp;
    }
}


