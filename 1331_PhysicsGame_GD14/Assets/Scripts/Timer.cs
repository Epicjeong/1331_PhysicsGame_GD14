using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float _time;
    [SerializeField] private TextMeshProUGUI _timeText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        _timeText.text = "Score: " + _time;
    }
}
