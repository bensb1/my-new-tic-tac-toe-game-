using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable] public class Player
{
    public Image panel;
    public Text text;
    public Button button;
}
[System.Serializable] public class PlayerColor
{
    public Color panelColor;
    public Color textColor;
}

public class GameController : MonoBehaviour
{
    public Player playerX;
    public Player playerO;
    public PlayerColor activePlayerColor;
    public PlayerColor inactivePlayerColor;
    public GameObject gameOverPanel;
    public GameObject restartButton;
    public Text gameOverText;
    public GameObject startInfo;
    private string playerSide;
    private int moveCount;
    void Awake()
    {
        
        SetGameControllerReferenceOnButtons();
        
        gameOverPanel.SetActive(false);
        moveCount = 0;
        restartButton.SetActive(false);
     
    }
    public Text[] buttonList;
    void SetGameControllerReferenceOnButtons()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }
    public string GetPlayerSide()
    {
        return playerSide;
    }
    public void EndTurn()
    {
        moveCount++;
        if (buttonList[0].text == playerSide && buttonList[1].text == playerSide && buttonList[2].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[3].text == playerSide && buttonList[4].text == playerSide && buttonList[5].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[6].text == playerSide && buttonList[7].text == playerSide && buttonList[8].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[0].text == playerSide && buttonList[3].text == playerSide && buttonList[6].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[1].text == playerSide && buttonList[4].text == playerSide && buttonList[7].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[2].text == playerSide && buttonList[5].text == playerSide && buttonList[8].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[0].text == playerSide && buttonList[4].text == playerSide && buttonList[8].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[2].text == playerSide && buttonList[9].text == playerSide && buttonList[10].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[5].text == playerSide && buttonList[11].text == playerSide && buttonList[12].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[8].text == playerSide && buttonList[13].text == playerSide && buttonList[14].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[15].text == playerSide && buttonList[16].text == playerSide && buttonList[17].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[17].text == playerSide && buttonList[18].text == playerSide && buttonList[19].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[9].text == playerSide && buttonList[11].text == playerSide && buttonList[13].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[11].text == playerSide && buttonList[13].text == playerSide && buttonList[18].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[10].text == playerSide && buttonList[12].text == playerSide && buttonList[14].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[12].text == playerSide && buttonList[14].text == playerSide && buttonList[19].text == playerSide)
        {
            GameOver(playerSide);
        }
           else if (buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide)
        {
            GameOver(playerSide);
        }   else if (buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[2].text == playerSide && buttonList[11].text == playerSide && buttonList[14].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[1].text == playerSide && buttonList[5].text == playerSide && buttonList[13].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[5].text == playerSide && buttonList[13].text == playerSide && buttonList[19].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[3].text == playerSide && buttonList[7].text == playerSide && buttonList[17].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[17].text == playerSide && buttonList[13].text == playerSide && buttonList[12].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[16].text == playerSide && buttonList[8].text == playerSide && buttonList[11].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[8].text == playerSide && buttonList[11].text == playerSide && buttonList[10].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[15].text == playerSide && buttonList[7].text == playerSide && buttonList[5].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[7].text == playerSide && buttonList[5].text == playerSide && buttonList[9].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (buttonList[4].text == playerSide && buttonList[8].text == playerSide && buttonList[18].text == playerSide)
        {
            GameOver(playerSide);
        }
        else if (moveCount >= 9)
        {
            GameOver("draw");
        }
        else
        {
            ChangeSides();
        }
    }
    void GameOver(string winningPlayer)
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            SetBoardInteractable(false);

        }
      
        restartButton.SetActive(true);
        if (winningPlayer == "draw")
        {
            SetGameOverText("It's a Draw!");
            SetPlayerColorsInactive();
        }
        else
        {
            SetGameOverText(winningPlayer + " Wins!");
        }
    }
    void ChangeSides()
    {
        playerSide = (playerSide == "X") ? "O" : "X"; // Note: Capital Letters for "X" and "O"
        if (playerSide == "X")
        {
            SetPlayerColors(playerX, playerO);
        }
        else
        {
            SetPlayerColors(playerO, playerX);
        }
    }
    void SetGameOverText(string value)
    {
        gameOverPanel.SetActive(true);
        gameOverText.text = value;
    }
    public void RestartGame()
    {
        
        moveCount = 0;
        gameOverPanel.SetActive(false);
        restartButton.SetActive(false);
        SetPlayerButtons(true);
        SetPlayerColorsInactive();
        startInfo.SetActive(true);
        //  SetBoardInteractable(true);
        for (int i = 0; i < buttonList.Length; i++)
        {
         
            buttonList[i].text = "";
        }

    }
    void SetBoardInteractable(bool toggle)
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<Button>().interactable = toggle;
        }
    }
    void SetPlayerColors(Player newPlayer, Player oldPlayer)
    {
        newPlayer.panel.color = activePlayerColor.panelColor;
        newPlayer.text.color = activePlayerColor.textColor;
        oldPlayer.panel.color = inactivePlayerColor.panelColor;
        oldPlayer.text.color = inactivePlayerColor.textColor;
    }
    public void SetStartingSide(string startingSide)
    {
        playerSide = startingSide;
        if (playerSide == "X")
        {
            SetPlayerColors(playerX, playerO);
        }
        else
        {
            SetPlayerColors(playerO, playerX);
        }
        StartGame();
    }
    void StartGame()
    {
        SetBoardInteractable(true);
        SetPlayerButtons(false);
        startInfo.SetActive(false);
    }
    void SetPlayerButtons(bool toggle)
    {
        playerX.button.interactable = toggle;
        playerO.button.interactable = toggle;
    }
    void SetPlayerColorsInactive()
    {
        playerX.panel.color = inactivePlayerColor.panelColor;
        playerX.text.color = inactivePlayerColor.textColor;
        playerO.panel.color = inactivePlayerColor.panelColor;
        playerO.text.color = inactivePlayerColor.textColor;
    }
}





