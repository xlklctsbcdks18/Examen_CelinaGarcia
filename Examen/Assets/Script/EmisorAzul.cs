using UnityEngine;
using System.Collections;

public class EmisorAzul : MonoBehaviour {
	public GameObject objetoPrefab;
	
	// Use this for initialization
	void Start () {
		Destroy (gameObject,1);
		
	}
	
	// Update is called once per frame
	void Update () {
		float pos;
		pos = Random.Range(-5,5);
		Vector3 newPos = new Vector3(this.transform.position.x+pos,this.transform.position.y, this.transform.position.z);
		Instantiate(objetoPrefab,newPos,Quaternion.identity);
	}
}
