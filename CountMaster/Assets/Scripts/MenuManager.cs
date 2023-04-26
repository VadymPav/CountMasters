using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
  [SerializeField] private GameObject startMenuObj;
  public TextMeshProUGUI coinsValueText;
  public static int coins;
  private void Start()
  {
    coinsValueText.text = PlayerPrefs.GetInt("Coins", 0).ToString();
    coins = PlayerPrefs.GetInt("Coins", 0);
  }
  public void StartTheGame()
  {
    startMenuObj.SetActive(false);
    PlayerManager.PlayerManagerInstance.gameState = true;
    
    PlayerManager.PlayerManagerInstance.player.GetChild(1).GetComponent<Animator>().SetBool("run",true);
  }
  
  public void IncreaseMoney()
  {
    coins++;
    PlayerPrefs.SetInt("Coins", coins);
    coinsValueText.text = PlayerPrefs.GetInt("Coins", 0).ToString();
  }
}
