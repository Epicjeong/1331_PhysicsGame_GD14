using TMPro;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private Timer _timer;
    [SerializeField] private TextMeshProUGUI _finalTimeText;
    [SerializeField] private AudioSource _winSound;

    private void OnTriggerEnter(Collider other)
    {
        _finalTimeText.text = "" + _timer._time;
        _winSound.Play();
        _winScreen.SetActive(true);
    }
}
