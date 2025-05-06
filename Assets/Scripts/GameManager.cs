using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    [SerializeField] private ScoreData scoreData;

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        score = scoreData.savedScore;
        UIManager.instance.UpdateScore(score);
    }
    public void AddScore(int amount) {
        score += amount;
        UIManager.instance.UpdateScore(score);
    }

    private void OnApplicationQuit()
    {
        scoreData.savedScore = score;


        EditorUtility.SetDirty(scoreData);
        AssetDatabase.SaveAssets();


        Debug.Log("Score saved: " + score);
    }
}
