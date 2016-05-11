using UnityEngine;
using System.IO;


[System.Serializable]
public class Datos  {


    public string nombre="Pepe";
  
    public int valor=25;

    [System.NonSerialized]
    public int NoSerializa = 333;
	
	
	
	public void Load () {
        
        Datos x = JsonUtility.FromJson<Datos>(File.ReadAllLines(Application.persistentDataPath + "/salida.json")[0]);
        nombre = x.nombre;
        valor = x.valor;
        Debug.Log("Leidos: " + x.nombre);
        
        
	}

    public void Save()
    {
        string x = JsonUtility.ToJson(this);
        Debug.Log(Application.persistentDataPath);
        File.WriteAllText(Application.persistentDataPath + "/salida.json", x);

    }

}
