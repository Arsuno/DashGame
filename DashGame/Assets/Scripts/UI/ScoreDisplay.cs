using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private Text _label;
    [SerializeField] private Score _score;

    #region MonoBehaviour
    private void OnEnable()
    {
        _score.ScoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        _score.ScoreChanged -= OnScoreChanged;
    }
    #endregion

    private void OnScoreChanged(int score)
    {
        LabelUpdate(score.ToString());
        
    }

    private void LabelUpdate(string text)
    {
        _label.text = text;
    }
}
