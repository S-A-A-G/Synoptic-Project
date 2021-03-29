using UnityEngine;
using UnityEngine.UI;

namespace HSVPicker.Examples
{
    public class ColorPickerTester : MonoBehaviour 
    {



        public SpriteRenderer sprite;
      
        public ColorPicker picker;

        public Color Color = Color.white;
        public bool SetColorOnStart = false;


	    // Use this for initialization
	    void Start () 
        {
            
            picker.onValueChanged.AddListener(color =>
            {
                //render.material.color = color;
                sprite.color = color;
                Color = color;
            });

            //render.material.color = picker.CurrentColor;
            sprite.color = picker.CurrentColor;
            if (SetColorOnStart) 
            {
                picker.CurrentColor = Color;
            }
 

        }

        // Update is called once per frame
        void Update () {
	
          
        }
    }
}