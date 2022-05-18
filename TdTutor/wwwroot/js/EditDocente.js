const formulario = document.getElementById('formulario');
const inputs = document.querySelectorAll('#formulario input');
document.getElementById('btnEnviar').disabled = true;

const expresiones = {
	nombre: /^[a-zA-Z0-9\_\-\s]{4,16}$/, // Letras, numeros, guion y guion_bajo
	materia: /^[a-zA-ZÀ-ÿ\s]{4,16}$/, // Letras y espacios, pueden llevar acentos.
	contrasenia: /^.{4,8}$/,
}

const campos = {
	nombre: false,
	materia: false,
	contrasenia: false,
}

const validarFormulario = (e) => {
	switch (e.target.name) {
		case "nombre":
			validarCampo(expresiones.nombre, e.target, 'nombre');
			break;
		case "materia":
			validarCampo(expresiones.materia, e.target, 'materia');
			break;
		case "contrasenia":
			validarCampo(expresiones.contrasenia, e.target, 'contrasenia');
			break;
	}
}

const validarCampo = (expresion, input, campo) => {
	if (expresion.test(input.value)) {
		document.getElementById(`grupo__${campo}`).classList.remove('formulario__grupo-incorrecto');
		document.getElementById(`grupo__${campo}`).classList.add('formulario__grupo-correcto');
		document.querySelector(`#grupo__${campo} i`).classList.add('fa-check-circle');
		document.querySelector(`#grupo__${campo} i`).classList.remove('fa-times-circle');
		document.querySelector(`#grupo__${campo} .formulario__input-error`).classList.remove('formulario__input-error-activo');
		campos[campo] = true;
	}
	else {
		document.getElementById(`grupo__${campo}`).classList.add('formulario__grupo-incorrecto');
		document.getElementById(`grupo__${campo}`).classList.remove('formulario__grupo-correcto');
		document.querySelector(`#grupo__${campo} i`).classList.add('fa-times-circle');
		document.querySelector(`#grupo__${campo} i`).classList.remove('fa-check-circle');
		document.querySelector(`#grupo__${campo} .formulario__input-error`).classList.add('formulario__input-error-activo');
		campos[campo] = false;
	}
}

inputs.forEach((input) => {
	input.addEventListener('keyup', validarFormulario);
	input.addEventListener('blur', validarFormulario);
	input.addEventListener('change', validarFormulario);
	input.addEventListener('input', validarFormulario);
});

formulario.addEventListener('change', (x) => {
	if (campos.nombre && campos.materia && campos.contrasenia && validarCampo) {
		document.getElementById('formulario__mensaje').classList.remove('formulario__mensaje-activo');
		document.getElementById('btnEnviar').disabled = false;
	} else {
		document.getElementById('btnEnviar').disabled = true;
		document.getElementById('formulario__mensaje').classList.add('formulario__mensaje-activo');
    }
});

formulario.addEventListener('submit', (e) => {

	if (campos.nombre && campos.materia && campos.contrasenia && validarCampo) {
		document.getElementById('formulario__mensaje-exito').classList.add('formulario__mensaje-exito-activo');
		setTimeout(() => {
			document.getElementById('formulario__mensaje-exito').classList.remove('formulario__mensaje-exito-activo');
		}, 5000);

		document.querySelectorAll('.formulario__grupo-correcto').forEach((icono) => {
			icono.classList.remove('formulario__grupo-correcto');
		});
	}
});