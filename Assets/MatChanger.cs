using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MatChanger : MonoBehaviour {
    public GameObject obj;
    public string fileName;
    Material objMat;
    Renderer objRenderer;
    Texture2D loadedTexture;

	void Start () {
        objRenderer = obj.GetComponent<Renderer>();
        objMat = objRenderer.material;
        loadedTexture = LoadPNG(fileName + ".jpg");
        objMat.SetTexture("_MainTex", loadedTexture);
    }
	
    public static Texture2D LoadPNG(string filePath)
    {
        Texture2D tex = null;
        byte[] fileData;
        if (File.Exists(filePath))
        {
            Debug.Log("Imagen " + filePath + " Encontrada");
            fileData = File.ReadAllBytes(filePath);
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData);
        }
        else
            Debug.Log("Imagen " + filePath + " No Encontrada");
        return tex;
    }
}
