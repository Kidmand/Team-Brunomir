using UnityEngine;

public class ScaleSpriteWithCanvas : MonoBehaviour
{
    public RectTransform canvasImageRect; // El RectTransform de la imagen en el Canvas
    public SpriteRenderer spriteRenderer;  // El SpriteRenderer del sprite que quieres escalar
    public const float ScaleCanvasXConst = 1.09705472f;
    public const float ScaleCanvasYConst = 1.09705472f;

    private void Start()
    {
        AdjustSpriteScale();
    }

    private void AdjustSpriteScale()
    {
        Vector3 spriteScale = spriteRenderer.transform.localScale;

        float ScaleXCanvas = canvasImageRect.localScale.x;
        float ScaleYCanvas = canvasImageRect.localScale.y;
        float crecimientoX = ScaleXCanvas - ScaleCanvasXConst;
        float crecimientoY = ScaleYCanvas - ScaleCanvasYConst;
        float heightScale, widthScale;
        
        Debug.Log("CrecimientoX: "+ crecimientoX + ", CrecimientoY: " + crecimientoY);
        
        if (crecimientoX >0f)
        	widthScale = spriteScale.x + crecimientoX*100;
        else widthScale = spriteScale.x + crecimientoX*100;
        
        if (crecimientoY >0f)
        	heightScale = spriteScale.y - crecimientoY*50;
        else heightScale = spriteScale.y - crecimientoY*50;
         Debug.Log("CrecimientoX: "+ widthScale + ", CrecimientoY: " + heightScale);

        // Aplica la escala al sprite
        spriteRenderer.transform.localScale = new Vector3(widthScale, heightScale, 1);
    }
}

