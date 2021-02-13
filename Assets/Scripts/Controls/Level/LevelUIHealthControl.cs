using UnityEngine;
using UnityEngine.UI;

public class LevelUIHealthControl : MonoBehaviour
{
    [SerializeField] HealthStateControl playerHealthState;
    [SerializeField] Image healthBar;

    private void OnEnable()
    {
        playerHealthState.OnHealthIncreased += IncreaseHealthBar;
        playerHealthState.OnHealthDecreased += DecreaseHealthBar;
    }

    private void OnDisable()
    {
        playerHealthState.OnHealthIncreased -= IncreaseHealthBar;
        playerHealthState.OnHealthDecreased -= DecreaseHealthBar;
    }

    private void IncreaseHealthBar(float amount)
    {
        UpdateHealthBar();
    }

    private void DecreaseHealthBar(float amount)
    {
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        float maxHealth = playerHealthState.MaxHealth;
        float currentHealth = playerHealthState.CurrentHealth;

        healthBar.fillAmount = currentHealth / maxHealth;
    }

}
