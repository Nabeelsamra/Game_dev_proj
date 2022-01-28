using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
	public GameObject gameLoseUI;
	public GameObject gameWinUI;
	bool gameIsOver;


	void Start()
	{
		Patrol.OnGuardHasSpottedPlayer += ShowGameLoseUI;
		//GameObject.FindGameObjectWithTag("Player").OnReachedEndOfLevel += ShowGameWinUI;
		
	}
	/*

	void Update()
	{
		if (gameIsOver)
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				SceneManager.LoadScene(0);
			}
		}
	}*/

	void ShowGameWinUI()
	{
		OnGameOver(gameWinUI);
	}

	void ShowGameLoseUI()
	{
		OnGameOver(gameLoseUI);
	}

	void OnGameOver(GameObject gameOverUI)
	{
		gameOverUI.SetActive(true);
		gameIsOver = true;
		Patrol.OnGuardHasSpottedPlayer -= ShowGameLoseUI;
		//GameObject.FindGameObjectWithTag("Player").OnReachedEndOfLevel -= ShowGameWinUI;
	}
}
