using UnityEngine;

public class Stars : MonoBehaviour {

	[SerializeField]
	private int Occurance = 10;
	[SerializeField]
	private GameObject Star;
	[SerializeField]
	private int Radius = 5;
	[SerializeField]
	private Vector3 Offset;

	private int Temp_RandomInt;
	private GameObject Temp_Clone;

	private void Start()
	{
		Debug.Log(transform.name + ": Drawing Stars");
		for (int i = 0; i < Occurance * 10; i++)
		{
			Debug.Log(transform.name + ": Testing #" + i);
			Temp_RandomInt = Random.Range(0, Occurance + 1);
			if (Temp_RandomInt == 1)
			{
				Debug.Log(transform.name + ": Drawing Star #" + i);
				Temp_Clone = Instantiate(Star);
				Temp_Clone.transform.position = new Vector3(Random.Range(-1, Radius + 1), Random.Range(-1, Radius + 1), 1) + Offset;
			}
		}
		Debug.Log(transform.name + ": Stars Drawn");
	}
}
