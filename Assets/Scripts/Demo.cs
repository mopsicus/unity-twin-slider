using Mopsicus.TwinSlider;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour {

	[SerializeField]
	private TwinSlider DemoSlider;

	[SerializeField]
	private Text ValuesText;

	private void Start () {
		DemoSlider.OnSliderChange += OnValuesChanges;
	}

	void OnValuesChanges (float value1, float value2) {
		ValuesText.text = string.Format ("value1 = {0}, value2 = {1}", value1, value2);
	}

}