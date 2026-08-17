# Gestion-De-Pacientes-Proyecto-Final-Gamalier-
Repositorio del sistema de gestión de pacientes para nuestro trabajo final.

Participantes:
John Manuel Nolasco Peguero (2026-0523)
Jhon Jairo Reyes Portes (2026-0013)
Bendrys Valeria Acosta Paulino (2026-0493)
Sintia Raymelis De Jesus Peguero (2026-0226)
Enyer Grey Severino (2020-0866)


Instrucciones
Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas.
 
Prerrequisitos
Qué cosas necesitas para instalar el software y cómo instalarlas:
• Visual Studio 2019 o superior
• .NET Framework / .NET Core compatible con Windows Forms
 
Instalación:

Una paso a paso que te dice lo que debes ejecutar para tener un entorno de desarrollo ejecutándose:
• Clona el repositorio en tu máquina local: git clone https://github.com/tu-usuario/tu-repositorio.git
• Abre la solución .sln en Visual Studio.
• Compila el proyecto presionando Ctrl + Shift + B para restaurar paquetes y verificar que todo esté en orden.
• Presiona F5 o haz clic en el botón Iniciar para ejecutar el formulario.

Descripción y Propósito de la Aplicación
El Sistema de Gestión de Pacientes es una aplicación de escritorio desarrollada en C# con Windows Forms. Su propósito principal es facilitar la administración, registro y control de la información médica básica de los pacientes mediante una interfaz gráfica.
Permite centralizar el flujo de trabajo operativo de un consultorio o centro médico, abarcando desde la captura inicial de datos hasta la consulta, actualización y eliminación de registros.
Información Ingresada a través de Controles

La captura de datos se realiza de forma interactiva mediante los siguientes controles del formulario:
• ID (txtBID): Identificador único del paciente.
• Nombre (txtBNombre): Nombre completo del paciente.
• Edad (textBox1): Valor numérico entero para la edad del paciente.
• Diagnóstico (textBox2): Descripción de la condición médica.
• Sexo (cmbSexo): Selector desplegable con las opciones de la enumeración Sexo.
• Estado (cmbEstado): Selección del estado clínico del paciente mediante la enumeración EstadoPaciente.
• Fecha de Ingreso (cmbFechaIngreso): Registro de la fecha de alta en el sistema.
• ID de Búsqueda (textBox3): Campo utilizado para filtrar pacientes por su ID.

Explicación de las Funciones
• Form1_Load: Inicializa la interfaz, puebla los ComboBox con los valores de los Enum (Sexo y EstadoPaciente) y llena el DataGridView con la lista inicial.
• btnAgregar_Click: Toma los datos ingresados en los controles, valida la información y registra un nuevo objeto Paciente en la lista.
• btnActualizar_Click: Reemplaza los datos del paciente existente por la nueva información ingresada en el formulario.
• bntEliminar_Click: Solicita confirmación y elimina al paciente seleccionado de la lista dinámica según su ID.
• btnBuscarPorId_Click: Busca un paciente por su identificador único, carga sus datos en los controles y resalta la fila correspondiente en la grilla.
• btnBuscarPorNombre_Click: Filtra la colección de pacientes según el nombre especificado.
• btnListarTodos_Click: Restablece la vista de la tabla mostrando el listado completo.
• btnLimpiar_Click: Vacía los campos de texto y restablece los selectores del formulario.
• RefrescarGrilla: Método auxiliar encargado de desvincular y reasignar la fuente de datos al DataGridView.
• CargarPacienteEnFormulario: Asigna las propiedades de un objeto Paciente a los controles correspondientes de la interfaz.
• dataGridView1_CellContentClick: Carga los datos de la fila seleccionada dentro de los controles de edición al interactuar con el DataGridView.

Lista Dinámica
El sistema hace uso de una Lista Dinámica (List<Paciente>) gestionada a través de la clase GestorPacientes:
• Almacenamiento en Memoria: Permite agregar, consultar, modificar y remover registros de forma flexible sin requerir un tamaño estático predefinido.
• Sincronización: Cada operación realizada sobre la lista invoca el refresco dinámico de la interfaz, asegurando que la grilla refleje los cambios inmediatamente.

Datos y Resultados de Salida
• DataGridView (Grilla Principal): Es el canal de salida primario donde se visualizan los registros estructurados en columnas: ID, Nombre, Edad, Diagnóstico, Sexo, Estado y Fecha de Ingreso.
• Campos Autocompletados: Salida visual de retorno donde los datos del paciente se vuelven a volcar en los controles del formulario tras realizar una búsqueda o seleccionar una fila.
Mensajes de Confirmación y Error

La aplicación utiliza cuadros de diálogo modal (MessageBox) para informar al usuario sobre el estado de las operaciones:
Mensajes de Error y Advertencia
• Omitir ID en búsquedas o acciones: "Ingrese un ID para buscar." El campo ID es obligatorio."
• Formato numérico incorrecto: "Edad inválida. Ingrese un número entero."
• Búsqueda sin resultados: "No se encontró el paciente con ese ID."
Mensajes de Confirmación y Éxito
• Alta exitosa: "Paciente agregado exitosamente."
• Actualización exitosa: "Paciente actualizado exitosamente."
• Confirmación de Eliminación: Confirma la acción mediante un cuadro de diálogo con opciones Sí/No ("¿Desea eliminar al paciente con ID 'X'?").

Evidencia Visual y Ejemplos de Uso
1. Vista General del Formulario

<img width="601" height="269" alt="image" src="https://github.com/user-attachments/assets/6975ad18-c051-461d-9f40-cff9aaa51890" />

 
2. Ejemplo: Agregar Paciente
• Acción: Completar los campos del paciente y presionar Agregar.
<img width="540" height="242" alt="image" src="https://github.com/user-attachments/assets/f1b33456-afbc-4c12-9a98-a1ba37da92ea" />

• Resultado: Cuadro de confirmación e inclusión del nuevo registro en la grilla.
3. Ejemplo: Eliminar Paciente
• Acción: Seleccionar o ingresar el ID y hacer clic en Eliminar.
• Resultado: Ventana modal de confirmación y remoción del paciente de la lista.
<img width="541" height="240" alt="image" src="https://github.com/user-attachments/assets/a668ffa8-9a78-4afd-b70a-5c27d03069e3" />

4. Ejemplo: Limpiar
• Acción: Seleccionar Limpiar para poder registrar otro paciente.
• Resultado: La ventana queda limpia para agregar otro paciente.
<img width="553" height="249" alt="image" src="https://github.com/user-attachments/assets/85c8bf6c-1485-4f80-a22b-22f06b1c42ba" />

 
5. Ejemplo: Búsqueda y Listado
• Acción: Buscar un paciente por su ID
• Resultado: Información del paciente
<img width="607" height="273" alt="image" src="https://github.com/user-attachments/assets/65037a2e-2dac-48a0-9207-1cbb73c75282" />

Construido con:
• C# - lenguaje de programación.
• Windows Forms - framework para la interfaz gráfica de usuario.
