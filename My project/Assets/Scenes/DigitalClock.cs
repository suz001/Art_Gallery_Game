using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DigitalClock : MonoBehaviour
{
    public TimeManager tm;
    public TextMeshProUGUI display;

    public bool _24HourClock = true;

    // Start is called before the first frame update
    void Start()
    {
        tm = FindObjectOfType<TimeManager>();
        display = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_24HourClock)
            display.text = tm.Clock24Hour();
        else
            display.text = tm.Clock12Hour();
    }
}