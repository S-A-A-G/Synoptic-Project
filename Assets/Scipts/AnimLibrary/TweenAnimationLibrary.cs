using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenAnimationLibrary : MonoBehaviour
{
	
	public float tweenTime;
    public float xPoint = 1000f;

    public enum AnimChoice { EaseBounce, SlideL, SlideR };

    public AnimChoice playerChoice;
	
    // Start is called before the first frame update
    void Start()
    {
          Tween();
    }

     public void Tween()
    {
        LeanTween.cancel(gameObject);
        transform.localScale = Vector3.one;
        
        if (playerChoice == AnimChoice.EaseBounce)
        {

            LeanTween.scale(gameObject, Vector3.one * 2, tweenTime).setEasePunch();

        }
        else if(playerChoice == AnimChoice.SlideL)
        {

            LeanTween.moveX(gameObject, xPoint, tweenTime).setEase(LeanTweenType.easeInQuad).setDelay(1f);

        }
        else if (playerChoice == AnimChoice.SlideR)
        {

            LeanTween.moveX(gameObject, xPoint, tweenTime).setEase(LeanTweenType.easeInQuad).setDelay(1f);

        }
    }
}
