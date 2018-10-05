using UnityEngine;

[CreateAssetMenu]

public class AddValue : ScriptableObject
{

	public FloatData Data;
    
	public void OnAddValue (FloatData outsideData)
	{
		outsideData.Value += Data.Value;
	}

}
