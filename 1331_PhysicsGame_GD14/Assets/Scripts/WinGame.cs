using TMPro;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private Timer _timer;
    [SerializeField] private TextMeshProUGUI _finalTimeText;

    private void OnTriggerEnter(Collider other)
    {
        _finalTimeText.text = "" + _timer._time;
        _winScreen.SetActive(true);
    }
}
