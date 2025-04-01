using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
public class TestTimer : MonoBehaviour
{
    [SerializeField]
    public int delayMillisecond = 2000;

    [SerializeField]
    public TextMeshProUGUI debugText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private async void Start()
    {
        await TestTimerSample();
    }

    private async UniTask TestTimerSample()
    {
        await UniTask.Delay(delayMillisecond);
        string debugMessage = "Unitask Test " + delayMillisecond;
        Debug.Log(debugMessage);
        debugText.text = debugMessage;
    }
}
