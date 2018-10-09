using UnityEngine;

public class IfStatement : MonoBehaviour
{

	public FloatData CoinValue, GoldValue;
	public FloatData PlayerHealth;
	
	void Update () {

		if (CoinValue.Value > GoldValue.Value)
		{
			print("Coin Added to Inventory.");
		}
		else
		{
			print("Gold Added to Inventory.");
		}

		if (PlayerHealth.Value <= 0)

		{
			print("You Have Died.");
		}
		
	}
}
