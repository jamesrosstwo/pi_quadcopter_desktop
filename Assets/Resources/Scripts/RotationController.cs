using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RotationController : MonoBehaviour {

	private TextMeshProUGUI _xRotationText;
	private TextMeshProUGUI _yRotationText;
	private TextMeshProUGUI _zRotationText;

	void Start () {
		_xRotationText = transform.Find("X Rotation").gameObject.GetComponent<TextMeshProUGUI>();
		_yRotationText = transform.Find("Y Rotation").gameObject.GetComponent<TextMeshProUGUI>();
		_zRotationText = transform.Find("Z Rotation").gameObject.GetComponent<TextMeshProUGUI>();
	}
	
	void Update ()
	{
		UpdateRotationText();
		UpdateNavSphere();
	}

	private void UpdateNavSphere()
	{
		GameObject sphere = transform.Find("NavSphere").gameObject;
		sphere.transform.rotation = Quaternion.Euler(Quadcopter.Rotation);
	}

	private void UpdateRotationText()
	{
		_xRotationText.text = "X Rotation: " + (int)Quadcopter.Data.rotation_x + "°";
		_yRotationText.text = "Y Rotation: " + (int)Quadcopter.Data.rotation_y + "°";
		_zRotationText.text = "Z Rotation: " + (int)Quadcopter.Data.rotation_z + "°";
		Quadcopter.Rotation = new Vector3(Quadcopter.Data.rotation_x, Quadcopter.Data.rotation_y, Quadcopter.Data.rotation_z);
	}
}
