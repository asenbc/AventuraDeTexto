using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Añadimos la librería para poder usar componentes de la UI
using TMPro; //Añadimos la librería para poder acceder a los TextMeshPro

public class AdventureGameController : MonoBehaviour
{
    //Con esto podemos acceder al Texto de la UI
    [SerializeField] TextMeshProUGUI textComponent;

    //Referencia de tipo State (osea de la clase State), que usamos
     //para acceder a las variables y métodos del script State
    State state; //Este estado irá cambiando conforme avanza el juego

    //Será el estado inicial en el que emipeza el juego
    [SerializeField] State startingState;

    // Start is called before the first frame update
    void Start()
    {
        //El estado actual será el estado inicial del juego
        state = startingState;
        //Accedemos al compoonente text dentro del textComponent(StoryText)
        //y metemos lo que haya dentro del campo storyText del estado actual
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        //Hacemos la llamada al método
        ManageState();
    }

    //Método para manegar el cambio entre estados
    private void ManageState()
    {
        //Generamos un array de estados, donde guardamos los estados a los que podemos ir desde el estado actual en el que estamos
        var nextStates = state.GetNextStates(); // <=> State[] nextStates = state.GetNextStates();
        //Si pulsamos la tecla 1 del teclado
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Del estado en el que esté, pasa al siguiente estado que esté en la posición del array 0
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        //Actualizamos el texto del juego, con el del siguiente estado al que entramos
        textComponent.text = state.GetStateStory();
        
    }
}
