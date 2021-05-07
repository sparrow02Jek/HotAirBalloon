using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public event UnityAction<float> ApplyDamageEvent;
    public event UnityAction<float> RegenerationEvent;
    public event UnityAction<float> SetMaxHpEvent;
    public event UnityAction DeathEvent;

    [Header("Health Settings")]

    [SerializeField] private float _maxHp = 100;
    
    public float CurrentHp { get; private set; }

    private void Start()
    {
        CurrentHp = _maxHp;

        SetMaxHpEvent?.Invoke(_maxHp);

        SubscribeToEvents();
    }


    public void ApplyDamage(float dmg)
    {
        ApplyDamageEvent?.Invoke(dmg);
    }


    public void Regeneration(float hp)
    {
        RegenerationEvent?.Invoke(hp);
    }

    public void Death()
    {
        DeathEvent?.Invoke();
    }

    private void SubscribeToEvents()
    {
        DeathEvent += OnDeath;

        ApplyDamageEvent += OnTakeDamage;
        RegenerationEvent += OnHeal;
    }

    private void OnDeath()
    {
        gameObject.SetActive(false);
    }

    private void OnTakeDamage(float dmg)
    {
        CurrentHp -= dmg;

        Mathf.Clamp(CurrentHp, 0, _maxHp);

        if (CurrentHp <= 0)
            Death();
    }

    private void OnHeal(float hp)
    {
        CurrentHp += hp;
        Mathf.Clamp(CurrentHp, 0, _maxHp);
    }
}
