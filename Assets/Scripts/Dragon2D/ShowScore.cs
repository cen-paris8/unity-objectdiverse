using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    int scoreValue;
    private void Start()
    {
        scoreValue = Score.Instance.ScoreValue;
    }
    private void Update()
    {
        Debug.Log("resultat: " + scoreValue);
        GetComponent<Text>().text = scoreValue.ToString();
    }
}
