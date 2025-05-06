using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private Text scoreUI;

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }

    public void UpdateScore(int newScore) {
        scoreUI.text = "Score: " + newScore;
    }
}
