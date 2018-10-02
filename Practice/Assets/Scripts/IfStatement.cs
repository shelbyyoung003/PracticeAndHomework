using UnityEngine;

public class IfStatement : MonoBehaviour
{

	public FloatData CoinValue, GoldValue;
	
	void Update () {

		if (CoinValue.Value > GoldValue.Value)
		{
			print("Coin Added to Inventory.");
		}
		else
		{
			print("Gold Added to Inventory.");
		}
		
	}
}
