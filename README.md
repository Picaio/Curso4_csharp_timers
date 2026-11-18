# ⚡ Curso C# para Electrónica #4 | Timers y Chart

<p align="center">
  <b>Control de tiempo, parpadeo de LED, modos One-Shot/PWM y visualización gráfica en tiempo real con Windows Forms.</b>
</p>

<p align="center">
  <a href="https://youtu.be/QhzgmqUs3n8">
    <img src="https://img.shields.io/badge/YouTube-Ver%20Video-red?style=for-the-badge&logo=youtube" alt="Ver video en YouTube">
  </a>
</p>

---

## 📌 Descripción del Proyecto
Este repositorio corresponde al **capítulo 4** del curso de C# aplicado a la electrónica y automatización en el canal **PicaioVideos**. Aquí aprenderás a integrar temporizadores (`Timer`) y gráficos en tiempo real (`Chart`) para simular comportamientos de microcontroladores y sistemas embebidos directamente desde una interfaz de escritorio en C#.

---

## 🎯 Temas Principales
- ⏱️ **Uso del Componente `Timer`**: Configuración de intervalos, activación (`Enabled`), métodos `Start`/`Stop` y manejo del evento `Tick`.
- 📊 **Gráficas en Tiempo Real (`Chart`)**: Instalación de dependencias por NuGet, configuración estética de ejes y limitación de ventana de visualización.
- 💡 **Modos de Operación**:
  - Parpadeo de LED (`Blink`).
  - Disparo único (`One-Shot`).
  - Simulación de PWM / Tren de pulsos.
- 🖼️ **Gestión de Recursos**: Cambio dinámico de estados visuales (`LED ON` / `LED OFF`) mediante `Properties.Resources`.

---

## 🛠️ Requisitos y Dependencias
Para ejecutar o compilar este proyecto correctamente, asegúrate de tener instalado:
- **Visual Studio** (con la carga de trabajo de desarrollo de escritorio de .NET / Windows Forms).
- **Paquete NuGet de Gráficas**: 
  > Si al clonar el repositorio el control `Chart` no aparece o marca error, búscalo en el Administrador de Paquetes NuGet e instala:
  `System.Windows.Forms.DataVisualization`

---

## 📁 Estructura del Código Clave

El núcleo del funcionamiento del temporizador y la actualización gráfica se maneja mediante el evento `Tick`:

```csharp
private void timer1_Tick(object sender, EventArgs e)
{
    // Aumentar contador y verificar modo de operación
    contador++;
    
    // Actualizar estado visual del LED y valores de la gráfica
    ActualizarInterfazVisual();
}
```

---

## 📺 Enlaces y Recursos
- **Video Explicativo:** [YouTube - Curso C# para Electrónica #4](https://youtu.be/QhzgmqUs3n8)
- **Canal de YouTube:** [@PicaioVideos](https://www.youtube.com/@PicaioVideos)

---

## 📄 Licencia
Este proyecto es de carácter educativo y libre para uso de la comunidad. 

---
<p align="center">Desarrollado con 💻 y ⚡ por <b>PicaioVideos</b>.</p>
