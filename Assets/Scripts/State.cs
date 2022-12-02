using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Es un atributo de la clase que nos permite crear ScriptableObject de tipo State desde la ventana de Project
[CreateAssetMenu(menuName = "State")]
//Esta clase deriva ahora de los ScriptableObject
public class State : ScriptableObject
{
    //Genero un campo de texto de strings, con un tamaño específico
    //[SerializeField] es un atributo que permite que una variable o referencia siga siendo
     //privada pero accesible desde el editor de Unity
    //[TextArea(,)] es un atributo que permite crear un cuadro de texto
     //con la cantidad de líneas escalable
    [TextArea(14, 10)] [SerializeField] string storyText;

    //Array de estados a los que podemos ir desde le estado actual
    [SerializeField] State[] nextStates;

    //Método que nos devuelve el contenido de la caja de texto del ScripableObject
    public string GetStateStory()
    {
        return storyText;
    }

    //Método que nos devuelve los estados a los que podemos ir desde el estado actual
    public State[] GetNextStates()
    {
        return nextStates;
    }


}
