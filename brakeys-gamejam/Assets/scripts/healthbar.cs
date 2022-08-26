using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider frontSlider;
    public Gradient gradient;
    public Image fill;

    public void setMaxHealth(int health)
    {
        frontSlider.maxValue = health;
        frontSlider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void setHealth(int health)
    {
        frontSlider.value = health;

        fill.color = gradient.Evaluate(frontSlider.normalizedValue);
    }
}
