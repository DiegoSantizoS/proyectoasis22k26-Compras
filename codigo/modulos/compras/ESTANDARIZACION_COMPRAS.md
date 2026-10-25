# Instrucciones de estandarización: Compras y Cuentas por Pagar

Proyecto Terminus · Embutidos de Calidad S.A.  
Base normativa: EST-10, versión 1.1, vigente desde el 13/10/2026.  
Guía preparada el 17/10/2026 para desarrolladores y agentes de código.

## 1. Alcance y prioridad de las instrucciones

Aplicar esta guía al MDI de Compras, sus formularios, bibliotecas, controles compartidos, acceso a datos, reportes y ayudas. Es una guía de implementación; no sustituye ni modifica la estandarización firmada.

Distinguir las siguientes fuentes:

- **Norma EST-10:** obligación tomada de la V1.1. Las referencias de página de esta guía corresponden a la numeración impresa; sumar dos para obtener la página del PDF.
- **Requerimiento funcional:** obligación del documento Requerimientos Embutidos de Calidad, independiente de la estandarización visual.
- **Acuerdo del módulo:** organización de Compras previamente definida por el equipo; no presentarla como exigencia textual de EST-10.
- **Recomendación técnica:** forma de implementar o verificar una obligación, sin atribuirla al documento firmado.

Usar la V1.1 como referencia para esta guía. La V1.0 es antecedente y no debe reintroducir criterios incompatibles con la versión posterior. El informe de pruebas de Consultas sirve como antecedente de errores que deben evitarse, no como revisión realizada al código de Compras.

Antes de cambiar código, inventariar soluciones, proyectos, formularios, referencias, recursos y aplicaciones registradas. No asumir que esta guía acredita el cumplimiento del repositorio: debe verificarse contra el código real.

## 2. Herramientas y organización del repositorio

**Norma EST-10, pp. 7–9 y 49–53:**

- Usar Visual Studio Community 2022.
- Crear las tres capas como bibliotecas de clases de .NET Framework 4.8.
- Usar Windows Forms .NET Framework 4.8 para el proyecto ejecutable de escritorio.
- No migrar el módulo de escritorio a .NET 8 por interpretar la tabla de herramientas: .NET 8 LTS corresponde a Blazor y .NET MAUI.
- Mantener el código del módulo dentro de `codigo/modulos/[NombreModulo]/`, en la carpeta real asignada por el repositorio.
- Conservar la separación entre ejecutable y bibliotecas MVC indicada por la norma. No reorganizar las carpetas raíz del proyecto.
- Colocar manuales en `manuales/`, recursos visuales en `recursos/`, reportes generados en `reportes/` y SQL en `scripts/`, dentro del espacio correspondiente al módulo.
- Mantener `prototipos/` vacío mientras no exista instrucción del ingeniero.
- Consultar las capacitaciones del ingeniero disponibles en Canvas antes de implementar las convenciones correspondientes.

Nombres de proyectos:

| Tipo | Formato | Ejemplo |
| --- | --- | --- |
| Modelo | `CapaModelo_[Nombre]` | `CapaModelo_Compras` |
| Controlador | `CapaControlador_[Nombre]` | `CapaControlador_Compras` |
| Vista | `CapaVista_[Nombre]` | `CapaVista_Compras` |
| Ejecutable | `Ejecucion_[Nombre]` | `Ejecucion_Compras` |

Usar PascalCase en los segmentos y nombres sin tildes. Seguir los ejemplos explícitos `CapaVista_Compras`; no convertirlos en `Capa_Vista_Compras` por la redacción ambigua de la p. 53.

**Acuerdos del módulo:** conservar las soluciones por subproceso y la solución compartida `Componentes`, sin añadir automáticamente el sufijo `ComprasCXP`. Los subprocesos definidos son Movimientos de Proveedores, Pólizas, Órdenes de Compra, Pagos a Proveedores, Aprobación Financiera y Cierre de Movimientos. Esta división no aparece impuesta en EST-10. Verificar su correspondencia con la estructura formal del módulo y registrar cualquier diferencia pendiente, sin afirmar que tiene aprobación formal.

## 3. Arquitectura MVC y referencias

**Norma EST-10, pp. 13 y 51–53:**

| Capa | Responsabilidad | Evitar |
| --- | --- | --- |
| Vista | Formularios, presentación, captura de datos y mensajes al usuario; llamadas al Controlador | SQL, conexiones ODBC y acceso directo al Modelo |
| Controlador | Validación de datos, lógica de negocio y coordinación de llamadas al Modelo | SQL, ODBC y mensajes visuales directos |
| Modelo | Conexión, sentencias SQL y operaciones de persistencia | Dependencias de formularios o controles de Windows Forms |

- ODBC y SQL deben existir exclusivamente en CapaModelo, incluida la construcción de consultas.
- No pasar `ComboBox`, `DataGridView`, `TextBox`, `Form` u otros controles al Modelo. Transferir valores o estructuras de datos.
- Cada acción del usuario debe tener una responsabilidad clara en el Controlador.
- Crear formularios dentro de CapaVista. Mantener los controles reutilizables como controles; no convertirlos indiscriminadamente en ventanas.
- Respetar abstracción, encapsulación, herencia y polimorfismo. Aplicarlos con una función concreta, sin crear jerarquías artificiales solo para aparentar cumplimiento.
- Seguir la capacitación de referencias a DLL compiladas y ejecución desde otro proyecto, indicada en EST-10 p. 52.

**Recomendación técnica:** compilar según dependencias: Modelo, Controlador, Vista y Ejecutable; incorporar antes las bibliotecas compartidas que cada proyecto requiera. Evitar dependencias circulares. Usar rutas de referencia y de compilación relativas al repositorio, sin depender del disco C ni de directorios personales. Verificar la arquitectura de proceso y DSN ODBC compatibles; EST-10 no fija x86 o x64.

Si se refactoriza un formulario, actualizar su clase parcial, `.Designer.cs`, `.resx`, namespace, referencias del proyecto y eventos. No eliminar componentes compartidos que sigan siendo usados por otras soluciones.

## 4. Conexión y manejo de errores

**Norma EST-10, p. 8:** el nombre del DSN ODBC es **`EmbutidosS.A`**. Mantener exactamente ese nombre; `umg_didactica` pertenece a configuraciones anteriores y no es el DSN indicado en la V1.1.

**Aplicación técnica y antecedente QA:**

- Configurar y abrir la conexión únicamente desde Modelo; no sustituir ODBC por `SqlConnection` cuando se usa un DSN ODBC.
- Usar consultas parametrizadas para valores de entrada. Validar por lista permitida los identificadores dinámicos que no admitan parámetros.
- Liberar conexiones, comandos, lectores y transacciones de forma determinista.
- Propagar errores de datos hacia el Controlador y presentar su explicación en Vista. No colocar `MessageBox.Show` en Modelo ni Controlador.
- Evitar excepciones silenciadas y mensajes de éxito después de una operación fallida.
- No mostrar contraseñas ni cadenas de conexión en mensajes o registros.

El antecedente PRB-F-011 señala precisamente SQL y ODBC fuera del Modelo, controles visuales pasados al Modelo, errores de conexión, validaciones incompletas y mensajes desde Controlador. Aplicar esas lecciones a Compras sin atribuirle los defectos de Consultas.

## 5. Nomenclatura de código

**Norma EST-10, pp. 54–57:** utilizar `Compras` como identificador del módulo en controles y operaciones del módulo, de forma uniforme.

### 5.1 Controles

Formato: `Compras` + prefijo + nombre descriptivo en PascalCase.

| Control | Prefijo | Ejemplo |
| --- | --- | --- |
| DataGridView | Dgv | `ComprasDgvProveedores` |
| PictureBox | Pb | `ComprasPbLogo` |
| Label | Lbl | `ComprasLblProveedor` |
| Button | Btn | `ComprasBtnGuardar` |
| CheckBox | Chk | `ComprasChkActivo` |
| ComboBox | Cbo | `ComprasCboMoneda` |
| RadioButton | Rdo | `ComprasRdoCredito` |
| CheckedListBox | Clb | `ComprasClbDocumentos` |
| LinkLabel | Lnk | `ComprasLnkDetalle` |
| ListBox | Lst | `ComprasLstProveedores` |
| ListView | Lsv | `ComprasLsvDocumentos` |
| DateTimePicker | Dtp | `ComprasDtpFechaCompra` |
| TextBox | Txt | `ComprasTxtNumeroDocumento` |
| Control de usuario | Usr | `ComprasUsrDetalleCompra` |
| Panel | Pnl | `ComprasPnlContenido` |
| GroupBox | Gbx | `ComprasGbxTotales` |
| SplitContainer | Sc | `ComprasScDetalle` |
| TabControl | Tbc | `ComprasTbcDocumentos` |
| FlowLayoutPanel | Flp | `ComprasFlpAcciones` |
| TableLayoutPanel | Tlp | `ComprasTlpFormulario` |
| OpenFileDialog | Ofd | `ComprasOfdDocumento` |
| SaveFileDialog | Sfd | `ComprasSfdReporte` |
| ColorDialog | Cd | `ComprasCdColor` |
| FontDialog | Fd | `ComprasFdFuente` |
| FolderBrowserDialog | Fbd | `ComprasFbdDestino` |
| PrintDialog | Pd | `ComprasPdImprimir` |

No dejar nombres como `button1`, `textBox2` o `panel3`. Al renombrar, conservar las suscripciones de eventos y la correspondencia con el diseñador.

### 5.2 Clases, operaciones y variables

| Elemento | Regla | Ejemplo |
| --- | --- | --- |
| Clase | `Cls` + nombre | `ClsOrdenCompra` |
| Formulario | `Frm` + nombre | `FrmOrdenCompra` |
| Procedimiento | Módulo + `Proc` + nombre | `ComprasProcLimpiarFormulario` |
| Función | Módulo + `Func` + nombre | `ComprasFuncCalcularTotal` |
| Método | Módulo + `Met` + nombre | `ComprasMetGuardarCompra` |
| Variable local o parámetro | Nombre descriptivo en PascalCase, sin prefijo de tipo | `TotalCompra`, `CodigoProveedor` |
| Campo privado | Guion bajo + PascalCase | `_Controlador`, `_TotalCompra` |

La norma enumera Proc, Func y Met sin resolver completamente su solapamiento en C#. Mantener un criterio uniforme en el equipo; por ejemplo, Proc para procedimientos sin retorno, Func para cálculos con retorno y Met para otras operaciones. Este reparto es una convención de aplicación, no una definición textual adicional de EST-10.

No renombrar constructores, overrides o miembros exigidos por interfaces a un formato incompatible con C#. Limpiar sufijos accidentales de eventos como `_Click_1`, métodos duplicados, código comentado obsoleto y `using` innecesarios, verificando antes sus usos reales.

### 5.3 Tipos numéricos

- Usar `Decimal` para dinero, precios, impuestos, saldos y operaciones financieras.
- Usar `Double` como tipo predeterminado para valores numéricos no monetarios.
- No usar `float` de forma general; necesita una justificación técnica específica.
- No convertir claves, índices y contadores a `Double` de forma indiscriminada: conservar los tipos necesarios por sus contratos y documentar los casos que requieran aclaración. La norma habla de un tipo predeterminado, no describe cada tipo de identificador.

## 6. Paleta obligatoria de Compras

**Norma EST-10, sección 15.2, p. 36; tabla resumen p. 43:**

| Uso | HEX | RGB |
| --- | --- | --- |
| Principal del navegador | `#1E2A5A` | `30, 42, 90` |
| Acento del navegador | `#3D56A6` | `61, 86, 166` |
| Fondo de etiquetas destacadas | `#D9913E` | `217, 145, 62` |
| Fondo general | `#F6F7FA` | `246, 247, 250` |
| Fondo de botones | `#D5DCEF` | `213, 220, 239` |

Centralizar los valores para evitar variaciones entre formularios. Ejemplo de implementación:

```csharp
public static class ClsColoresCompras
{
    public static readonly Color PrincipalNavegador = Color.FromArgb(30, 42, 90);
    public static readonly Color AcentoNavegador = Color.FromArgb(61, 86, 166);
    public static readonly Color FondoEtiquetasDestacadas = Color.FromArgb(217, 145, 62);
    public static readonly Color FondoGeneral = Color.FromArgb(246, 247, 250);
    public static readonly Color FondoBotones = Color.FromArgb(213, 220, 239);
}
```

El ejemplo requiere `System.Drawing`. Los colores semánticos de validación y diálogos, rojo, verde y ámbar, están establecidos por las secciones 6 y 7; no eliminarlos por aplicar la paleta del módulo.

## 7. Tipografía, idioma y formatos

**Norma EST-10, pp. 12 y 24:**

- Títulos: Lucida en negrita y cursiva. Referencias: bienvenida de 40–45 pt y formularios de 16–20 pt.
- Campos de captura: Segoe UI regular; referencia de 14 pt.
- Etiquetas: Tahoma regular; referencia de 13 pt.
- Los tamaños son ajustables por legibilidad y diseño; no tratarlos como medidas obligatorias invariables.
- Toda la interfaz se redacta en español.
- Fechas visibles: `DD/MM/AAAA`; en formatos de .NET usar `dd/MM/yyyy`.
- Moneda visible con separador de miles y dos decimales: `Q 1,250.00`.
- Respetar el sistema multimoneda. El ejemplo con Q no autoriza convertir todos los registros a quetzales ni redondear prematuramente los cálculos internos.
- Botones con primera letra mayúscula: `Guardar`, `Modificar`, `Eliminar`, `Enviar`; no todo en mayúsculas.

## 8. MDI, navegación y ventanas

**Norma EST-10, pp. 14–19 y 25–27:**

- Respetar la secuencia `Login de Seguridad → Splash de Seguridad → MDI de Compras`. Integrar Seguridad; no crear autenticación paralela como solución definitiva.
- Abrir el MDI maximizado y conservar los botones estándar de minimizar, maximizar y cerrar del contenedor principal.
- La referencia del Dashboard es de `1554 × 1061` píxeles.
- La barra lateral tiene referencia `270 × 1014`, logo superior e iconos y etiquetas propios del módulo.
- Mostrar usuario y rol activos en el encabezado; no usar identidades simuladas en la entrega.
- Mantener la estructura de navegación aplicable: Archivo, Catálogos, Procesos, Reportes, Herramientas, Ayuda, Seguridad y Cerrar sesión.
- Incorporar botón hamburguesa: expandido muestra icono y etiqueta; colapsado muestra solo iconos.
- Diferenciar estados normal, hover y activo. Hover utiliza el tono secundario; activo muestra barra de acento a la izquierda y texto de acento.
- Mostrar los indicadores del módulo y conservar Información relevante y Nota de integración en la parte inferior.
- Mantener la mascota con sus colores originales; adaptar fondo y decoración a Compras.

Ventanas secundarias:

- Abrirlas como diálogos modales centrados sobre la ventana principal.
- Usar `MaximizeBox = false`; conservar minimizar y cerrar habilitados.
- Las ventanas de captura deben ser de tamaño fijo. Como aplicación técnica, usar un borde fijo apropiado.
- No superar el tamaño de referencia del Dashboard.
- Asignar `Form.Icon` con el icono representativo del módulo procedente del catálogo.
- Mostrar en `Form.Text` el código y nombre de ventana: `6001 – CrearCompra`.
- El nombre visible después del código debe usar PascalCase sin espacios.

**Acuerdo del módulo:** reservar `6000` para el MDI de Compras y asignar códigos sucesivos a los demás formularios. **Norma:** el rango completo de Compras y Cuentas por Pagar es **6000–6999**, compartido por todos sus subprocesos. No reiniciar la numeración por solución ni duplicar códigos. Conservar un inventario de código, formulario, título y registro de Seguridad.

La regla de clases `Frm...` y el nombre previo `MDICompras` deben conciliarse al revisar el código: `6000 – MDICompras` puede conservarse como título acordado, mientras que la clase debe seguir la nomenclatura formal o tener su excepción documentada. Actualizar referencias si se renombra la clase.

### 8.1 Ambigüedades que deben registrarse

1. **Resolución:** EST-10 exige funcionamiento completo en `1366 × 768`, aunque proporciona tamaños de referencia superiores para el Dashboard y la barra lateral. Usar distribución adaptable y verificar el área útil real, sin entregar formularios recortados. Si no se pueden satisfacer simultáneamente los tamaños literales y la resolución mínima, registrar la discrepancia para aclaración formal; no declarar resuelta la contradicción cambiando una regla silenciosamente.
2. **Contenedor:** la sección 5.1 indica panel `1263 × 983` con fondo `#FAF7F2`; la sección 15.2 asigna a Compras fondo general `#F6F7FA`. Mantener identificados ambos usos: contenedor descrito por 5.1 y superficies propias del módulo según 15.2. Si se pretende aplicar un único fondo a ambos, solicitar aclaración antes de presentarlo como criterio aprobado.
3. **Modal frente a MDI hijo:** la norma denomina MDI al principal, pero exige diálogos modales para ventanas secundarias. Usar el principal como propietario del diálogo; no sustituir la modalidad por formularios hijos no modales sin una excepción aprobada.

## 9. Botones, iconos y recursos

**Norma EST-10, pp. 19–20 y 41–46:**

- Usar exclusivamente los símbolos del catálogo general en Teams. Un mismo símbolo representa la misma acción en todos los módulos.
- Recolorear los botones con la paleta de Compras usando el proceso y prompt de la sección 16.2, con Gemini o ChatGPT.
- No dejar los botones activos en el blanco y negro original del catálogo.
- Conservar formas, textos, tipografía, bordes, grosor, posiciones, proporciones, dimensiones y transparencia del original. La operación es recoloreado, no rediseño.
- Entregar cada recurso por separado en PNG con el nombre original.
- Si hace falta redimensionar imágenes, la norma permite únicamente `https://www.iloveimg.com/es/redimensionar-imagen`.
- El tamaño de los botones queda a discreción del programador; EST-10 no fija universalmente 80 × 80.
- No recolorear ni generar variantes de la mascota: usar las imágenes del catálogo tal como están.
- Conservar las proporciones del logo oficial.
- Si falta un símbolo, solicitarlo al Área de Estandarización. No sustituirlo por uno externo sin autorización.

La tabla ERP define cinco roles cromáticos, mientras que el prompt genérico usa primario, secundario, fondo y acento. Conservar los roles oficiales de la paleta y validar el mapeo elegido contra el catálogo; no afirmar que EST-10 exige un único mapeo de cada zona del PNG para Compras.

## 10. Validaciones, mensajes y estados

**Norma EST-10, pp. 21–23:**

- Deshabilitar acciones que todavía no aplican. El botón deshabilitado debe verse gris claro y no tener efecto.
- Marcar los campos obligatorios con asterisco rojo junto a la etiqueta.
- Mostrar borde rojo y una explicación breve debajo del campo con error; reservar espacio para evitar superposiciones.
- Confirmar acciones irreversibles, especialmente eliminar: advertencia ámbar y opciones secundaria y primaria. La referencia personalizada usa `No` y `Sí, eliminar`.
- Después de guardar o modificar correctamente, mostrar éxito con verificación verde y `Aceptar`.
- Ante un fallo, mostrar error con X roja y `Aceptar`.
- Se admite el diseño estándar de Visual Studio o uno propio, respetando los criterios de icono y color. Si el diálogo nativo no reproduce el icono requerido, usar un diálogo propio para lograr el cumplimiento literal.

**Recomendación técnica:** validar requeridos, tipos, rangos, duplicados y relaciones antes de persistir. Para acciones financieras, comprobar también permisos y estado vigente en el Controlador; deshabilitar un botón no reemplaza el control de autorización.

## 11. Tablas y listados

**Norma EST-10, p. 23:**

- Aplicar filas con colores alternos.
- Permitir orden ascendente y descendente al pulsar encabezados; mostrar flecha del orden activo.
- Incorporar paginación inferior con total de registros y controles Anterior/Siguiente.
- Aplicar lo anterior a proveedores, compras, movimientos, pagos, consultas y demás tablas de resultados.

EST-10 no establece una cantidad fija de filas por página. Si el equipo usa 15, documentarlo como decisión del módulo. Verificar primera y última página, listado vacío y persistencia del criterio de orden al cambiar de página.

## 12. Reportes y ayudas

### 12.1 Reportes

**Norma EST-10, p. 44:** usar diseñador RDLC de Visual Studio y ReportViewer de Windows Forms.

| Archivo | Ubicación en el proyecto | Ejemplo |
| --- | --- | --- |
| Formulario | `frmReportes/` | `FrmReporteAntiguedadSaldos.cs` |
| Diseño | `Reportes/` | `RpReporteAntiguedadSaldos.rdlc` |

- Solo usar el logo oficial de Embutidos de Calidad S.A.
- Si se añade color, limitarlo a la paleta de Compras.
- Seguir la capacitación del ingeniero para formato y estructura.
- Diferenciar estas carpetas de código de la carpeta raíz `reportes/` destinada a reportes generados.

### 12.2 Ayudas

**Norma EST-10, p. 45:** usar HTML Help Workshop y un proyecto de ayuda por módulo.

- Crear una página por formulario con formato `[NombreDelFormulario]_Compras.htm`; ejemplo: `OrdenCompra_Compras.htm`.
- Mantener `ComprasAyudas.hhp`, `ComprasAyudas.hhc`, `ComprasAyudas.hhk` y `ComprasAyudas.chm`.
- Incluir logo oficial y mascota en la parte superior de cada página.
- Aplicar la paleta de Compras y un diseño accesible; tomar Seguridad como referencia.
- Consultar la capacitación de Ayudas de Canvas.

**Recomendación técnica:** abrir desde cada ventana el tema correspondiente y distribuir el CHM con rutas relativas a la aplicación. Verificar enlaces, imágenes, tabla de contenidos e índice.

Las carpetas `frmReportes` y `Reportes` sí están indicadas por V1.1. No aplicar a Compras una regla anterior de “solo carpeta Componentes en Vista” que impida estas ubicaciones; esa organización surgió en otro contexto del equipo.

## 13. Cuentas contables e integración financiera

**Norma EST-10, Parte III, pp. 61–64:**

- Usar formato **`C.GG.CC.SSS`**: clase de un dígito, grupo de dos, cuenta de dos y subcuenta de tres.
- Conservar ceros a la izquierda: `1.01.02.001`.
- Clases: 1 Activo, 2 Pasivo, 3 Patrimonio, 4 Ingresos, 5 Costos y 6 Gastos.
- No permitir letras, espacios ni caracteres no numéricos en los segmentos; los puntos son los separadores establecidos.
- Usar el catálogo único de Contabilidad; no crear uno paralelo dentro de Compras.
- Toda nueva cuenta requiere aprobación del responsable de Contabilidad.
- No modificar el código de una cuenta con transacciones ni permitir alterar la clase desde la interfaz.
- Antes de eliminar una cuenta, verificar que no tenga movimientos asociados.
- Validar automáticamente el formato al crear o editar cuentas, donde corresponda.

**Recomendación técnica:** almacenar el código como texto o en segmentos que conserven su representación. Validar estructura con `^[1-6]\.\d{2}\.\d{2}\.\d{3}$`, y además comprobar existencia, unicidad y autorización en el catálogo. La expresión por sí sola no acredita que la cuenta sea válida.

## 14. Requerimientos funcionales que Compras debe conservar

Estos puntos proceden de **Requerimientos Embutidos de Calidad**, pp. 2–3 y 7; no son reglas visuales de EST-10.

| Código | Comportamiento a conservar o verificar |
| --- | --- |
| RF-COM-01 | Catálogo de datos y movimientos de proveedores |
| RF-COM-02 | Precios de compra por proveedor y producto |
| RF-COM-03 | Emisión de órdenes de compra y registro de compras finalizadas |
| RF-COM-04 | Control de caja para pagos a proveedores |
| RF-COM-05 | Enlace automático con Contabilidad para pólizas de compras y pagos |
| RF-COM-06 | Balance de antigüedad de saldos de cuentas por pagar |
| RNF-COM-01 | Permisos por roles y aprobación jerárquica para autorizar pagos y compras |
| RNF-COM-02 | Consistencia ACID al generar pólizas después de cada pago registrado |

Respetar el flujo de referencia: consultar precios y movimientos, emitir orden y enviarla a Bancos para autorización, registrar compra recibida e incrementar la cuenta por pagar, programar pagos y generar integración contable y antigüedad de saldos.

La autorización de órdenes pertenece también al alcance de Bancos según RF-BAN-03. El subproceso interno Aprobación Financiera de Compras debe coordinar esa integración, sin reemplazarla por una aprobación local desconectada.

Para el MDI, los indicadores pedidos son:

- Promedio de antigüedad de saldos con proveedores.
- Porcentaje de órdenes autorizadas a tiempo mediante Tesorería.

El documento no fija fórmula, ponderación ni plazo para considerar una autorización “a tiempo”. Acordarlos con el área responsable y documentarlos antes de implementar; no inventar metas, plazos o datos de ejemplo como si fueran resultados reales.

## 15. Secuencia de trabajo para un desarrollador o agente

1. Inventariar estructura, aplicaciones 6000–6999, dependencias y pantallas. Revisar instrucciones del repositorio si existen.
2. Preparar una lista de incumplimientos con archivo, regla, evidencia y cambio necesario. Separar fallos normativos de recomendaciones.
3. Corregir separación MVC, referencias y configuración ODBC antes de modificar la apariencia.
4. Normalizar nombres y tipos sin romper contratos públicos, diseñador ni consumidores de DLL.
5. Centralizar paleta y estilos; aplicar fuentes, títulos y recursos oficiales.
6. Corregir modalidad, navegación, validaciones, tablas y adaptación a 1366 × 768.
7. Implementar o ajustar reportes, ayudas e integración contable según el alcance real.
8. Compilar todas las soluciones afectadas en orden de dependencia y realizar una prueba de ejecución.
9. Documentar cambios, verificaciones realizadas, pendientes y excepciones. No afirmar que una prueba se ejecutó cuando el entorno no la permite.

No cambiar reglas de negocio por una refactorización estética. No borrar código solo porque una búsqueda aislada no muestra referencias: comprobar diseñador, eventos, reflexión, recursos y consumidores externos.

## 16. Lista de aceptación

- [ ] Proyectos de escritorio y DLL apuntan a .NET Framework 4.8 y abren en VS Community 2022.
- [ ] Estructura del repositorio y nombres de proyectos cumplen EST-10.
- [ ] Vista llama a Controlador; SQL y ODBC están únicamente en Modelo.
- [ ] Modelo no recibe controles visuales; los mensajes se presentan desde Vista.
- [ ] DSN configurado como `EmbutidosS.A` y compatible con la arquitectura del proceso.
- [ ] Controles, clases, variables y operaciones cumplen la nomenclatura.
- [ ] Dinero usa Decimal; no hay uso general injustificado de float.
- [ ] Colores de Compras coinciden con los cinco valores oficiales.
- [ ] Tipografía, español, fechas y presentación multimoneda son correctos.
- [ ] Login y Splash de Seguridad preceden al MDI de Compras.
- [ ] MDI usa código 6000 y el resto de formularios tiene códigos únicos del rango 6000–6999.
- [ ] Cada formulario tiene título e icono correctos.
- [ ] Ventanas secundarias son modales, centradas y sin maximizar; captura usa tamaño fijo.
- [ ] La interfaz funciona completa en 1366 × 768; discrepancias de medidas quedan registradas.
- [ ] Navegación distingue normal, hover y activo; hamburguesa colapsa y expande.
- [ ] Botones usan recursos del catálogo recoloreados; mascota conserva sus colores originales.
- [ ] Campos obligatorios, errores, acciones deshabilitadas y diálogos cumplen la norma.
- [ ] Listados tienen filas alternas, orden visible, total y paginación.
- [ ] Reportes RDLC/ReportViewer y ayudas CHM siguen las convenciones de archivos y diseño.
- [ ] Cuentas contables respetan formato, catálogo único y restricciones por movimientos.
- [ ] Roles, aprobación jerárquica, envío a Bancos e integridad de pagos y pólizas están verificados.
- [ ] Se compilaron soluciones afectadas y se probaron rutas principales, cancelación y fallos de conexión.
- [ ] No quedan eventos duplicados, controles genéricos ni contenido temporal innecesario.
- [ ] Se registraron limitaciones de verificación y solicitudes de aclaración pendientes.

## 17. Excepciones y fuentes

EST-10 pp. 46 y 59 prohíbe cambios unilaterales en estructura, nomenclatura y criterios. Una excepción requiere solicitud formal al Área de Estandarización y aprobación; para cambios del documento visual, la p. 46 exige además reflejarlos en una nueva versión. No marcar una excepción como aprobada sin evidencia.

Contacto oficial indicado en p. 66: `estandarizacionterminus2026@gmail.com`. El documento indica respuesta máxima de 24 horas hábiles y el mismo plazo para incorporación de símbolos solicitados al catálogo. Esta guía no envía solicitudes ni acredita aprobaciones.

Fuentes utilizadas:

1. **Estandarización de SoftwareV1.1_FIRMADO(1).pdf**, EST-10 V1.1, 13/10/2026: fuente normativa principal. Referencias de página a lo largo de esta guía.
2. **Requerimientos Embutidos de Calidad.pdf**, pp. 2–3, 6–7: alcance de Compras, coordinación con Bancos e indicadores.
3. **PRB-F-011_Revisión del Software_V1.2_FIRMADO(1).pdf**, pp. 1–9: antecedentes de revisión de Consultas y errores recurrentes que se recomienda prevenir.

El caso de estudio aporta contexto empresarial; no establece nombres de clases ni reglas adicionales de interfaz. La planificación no se utiliza aquí para fijar fechas o porcentajes de entrega. Esta guía no audita el ZIP de Consultas ni supone que contiene el código actual del módulo de Compras.
