using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour {

    // REFERNCIA ANIMATOR PARA CAMBIARLE EL BOOLEANO
    public Animator  animatorHamburguesa;
    private const string PARAM_ANIMADO = "animado";

	public void Animar() {
        animatorHamburguesa.SetBool(PARAM_ANIMADO, true);
    }
}
