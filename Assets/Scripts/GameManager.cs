using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Score system")]
    [SerializeField] private TextMeshProUGUI scores;
    [SerializeField] private float scoreTimeout = 0.5f;
    private int _score;

    private void Start()
    {
        _score = 0;
        scores.text = _score.ToString();
        StartCoroutine(AddScore());
    }

    private IEnumerator AddScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(scoreTimeout);
            _score++;
            scores.text = _score.ToString();
        }
    }
}