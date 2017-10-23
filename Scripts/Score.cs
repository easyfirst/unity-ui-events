using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int _scoreValue = 0;

    private Text _scoreText
    {
        get
        {
            return GetComponent<Text>();
        }
    }

    public GameObject collectables;

    private void Awake()
    {
        SetupListeners();
    }   

    void SetupListeners()
    {
        foreach (Transform collectable in collectables.transform)
        {
            if(collectable.GetComponent<CollectableEvents>() != null)
                collectable.GetComponent<CollectableEvents>().OnPickup += UpdateScore;
        }
    }

    void UpdateScore(int value)
    {
        _scoreValue += value;

        _scoreText.text = "Score: " + _scoreValue;
    }
}
