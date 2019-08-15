using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Attached : GO DragonPrefab()
    // Obj : Lifecycle of red dragons
    // Param : 
    private Score Svar;
    private GameObject GOVar;
 
     public void Awake()
    {
        GOVar = GameObject.FindWithTag("Background");// GetComponent<Score>();
        Svar = GOVar.GetComponent<Score>();
    }
    
    public void ManageScore()
    {
        Svar.AddScore(1);
        Svar.ShowScore();
        Svar.SaveScore();
        Destroy(GOVar);
    }

    public void Die()
    {
        
        ManageScore();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
    }

    public void Respawn()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
    }
}
