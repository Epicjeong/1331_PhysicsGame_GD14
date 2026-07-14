using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float _timer;
    [SerializeField] private TextMeshProUGUI _timeText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        _timeText.text = "Score: " + _timer;
    }
}
