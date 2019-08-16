using UnityEngine;
using UnityEngine.UI;


public class Score : GenericSingletonClass<Score>
{
    // Attached : GO Background()
    // Obj : Manage score player

    public InputField IFvar;

    public int ScoreValue;

    public int MaxScore;

    // Obj : Add 1 when red dragon die
    public void AddScore(int nb)
    {
        if (nb > 0)
            ScoreValue += nb;
    }

    // Obj : Show score on InputFiel of Canvas
    public void ShowScore()
    {

        string value = ScoreValue.ToString();
        string valueMax = PlayerPrefs.GetInt("Score", 0).ToString();
        //IFvar.text = value + "    / Max:  " + valueMax;
        //TO DO manage score by an other way.
        
    }

    // Obj : Save score in PlayerPrefs 
    // ToDo : Move in a better storage 
    public void SaveScore()
    {
        
        if (PlayerPrefs.HasKey("Score") == true)
        {
            MaxScore = PlayerPrefs.GetInt("Score");
        }
        if (ScoreValue > MaxScore)
        {
            PlayerPrefs.SetInt("Score", ScoreValue);
            PlayerPrefs.Save();
        }
    }
}
