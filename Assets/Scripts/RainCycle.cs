using UnityEngine;

public class RainCycle : MonoBehaviour
{
    public GameObject rainSystem;
    public GameObject dayCycleSystem;
    LightManager lightManager;
    RainScript rainScript;

    const float startDay = 350;
    const float halfDay = 720;
    const float endDay = 1100;

    void Start()
    {
        rainScript = rainSystem.GetComponent<RainScript>();
        lightManager = dayCycleSystem.GetComponent<LightManager>();
    }

    // Link rain cycle with day cycle
    void Update()
    {
        float timeOfDay = lightManager.TimeOfDay;

        // Don't rain at night
        if (timeOfDay < startDay || timeOfDay > endDay)
        {
            rainScript.RainIntensity = 0;
        }
        // Increment intensity
        else if (timeOfDay < halfDay)
        {
            rainScript.RainIntensity = (timeOfDay - startDay) / (halfDay - startDay);
        }
        // Decrement intensity
        else
        {
            rainScript.RainIntensity = 1 - (timeOfDay - halfDay) / (endDay - halfDay);
        }
    }
}
