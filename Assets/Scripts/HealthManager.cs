using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float MaxHp { get; private set; }
    public float CurrentHp { get; private set; }


    public void Initialize(float maxHp)
    {
        CurrentHp = maxHp;
        MaxHp = maxHp;

    }
    private void Start()
    {
        CurrentHp = MaxHp;
    }

    public void TakeDamage(float amount)
    {
        CurrentHp -= amount;
        if (CurrentHp < 0)
        {
            CurrentHp = 0;
        }
    }

    public void Heal(float amount)
    {
        CurrentHp += amount;
        if (CurrentHp > MaxHp)
        {
            CurrentHp = MaxHp;
        }
    }

}