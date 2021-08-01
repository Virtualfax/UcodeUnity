using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public Text pointsText, livesText;

    public Image speedIndicator;
	public GameObject[] hearts;
    private PlayerData pd;
    private PlayerMovement pm;
	private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        pd = FindObjectOfType<PlayerData>();
        pm = FindObjectOfType<PlayerMovement>();
		gm = FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //pointsText.text = "Points: " + gm.getPoints();
        livesText.text = "Lives: " + gm.getLives();

        if (pm.speedBoosted)
        {
            speedIndicator.enabled = true;
        }
        else
        {
            speedIndicator.enabled = false;
        }
		if (gm.lives >= 3){
	 	  hearts[0].SetActive(true);
		  hearts[1].SetActive(true);
		  hearts[2].SetActive(true);
	 }
	 else if (gm.lives ==2){
	 hearts[0].SetActive(true);
		  hearts[1].SetActive(true);
		  hearts[2].SetActive(false);
	 }
	 else if (gm.lives == 1){
	 hearts[0].SetActive(true);
		  hearts[1].SetActive(false);
		  hearts[2].SetActive(false);
	 }
	 else{
	 	 hearts[0].SetActive(false);
		  hearts[1].SetActive(false);
		  hearts[2].SetActive(false);
	 }
    }
}
