using TMPro;
using UnityEngine;

public class ResultsManager : MonoBehaviour
{
    //[SerializeField] private TextMeshProUGUI normalLabel;
    [SerializeField] private TextMeshProUGUI protanLabel;
    [SerializeField] private TextMeshProUGUI deutanLabel;
    [SerializeField] private TextMeshProUGUI daltonicLabel;

    private void Start()
    {
        //normalLabel.text = $"{GameData.NormalPoints:F1}%";
        protanLabel.text = $"{GameData.ProtanPoints:F1}%";
        deutanLabel.text = $"{GameData.DeutanPoints:F1}%";
        daltonicLabel.text = $"{GameData.DaltonicPoints:F1}%";
    }
}
