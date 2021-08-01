using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int points = 0;
    public int lives;

	public GameObject endMenue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
		endMenue.SetActive(true);
        }
		else
		{
			endMenue.SetActive(false);
		}
    }
    public void loseLives(int live)
    {
			 lives -= live;
    }
	public int getLives()
	{
		return lives;
	}
	public int getPoints()
		{
			return points;
		}
		public void restartScene()
		{
			            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
}
