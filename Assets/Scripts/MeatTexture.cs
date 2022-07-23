using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatTexture : MonoBehaviour
{
    public List<Texture2D> MeatLevelTexture;
    private int currentLevel = 0;

    private Material meatMaterial;

    private void Awake() {
        meatMaterial = GetComponent<Renderer>().material;
        meatMaterial.mainTexture = MeatLevelTexture[currentLevel];
    }

    private void Update() {
        // DEBUG: On mouse click, change cooking level
        if (Input.GetMouseButtonDown(0)) {
            currentLevel++;
            if (currentLevel >= MeatLevelTexture.Count) {
                currentLevel = 0;
            }
            meatMaterial.mainTexture = MeatLevelTexture[currentLevel];
        }
    }
}
