using System;

public interface IHealthStateControlAll
{

    event Action<float> OnHealthDecreased;
    event Action OnMinHealthAchieved;
    event Action<float> OnHealthIncreased;
    event Action OnMaxHealthAchieved;

    bool TryIncreaseHealth(float amount);

    bool TryDecreaseHealth(float amount);

}
