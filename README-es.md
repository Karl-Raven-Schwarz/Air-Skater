# Air Skater

Un juego móvil de endless runner donde controlas a un patinador navegando a través de obstáculos. ¡Toca la pantalla para saltar y sobrevive el mayor tiempo posible mientras la dificultad aumenta!

**Desarrollador:** Maleon Games  
**Motor:** Unity 2019.4.14f1 (LTS)  
**Plataforma:** Android

[Read in English](README.md)

---

## Capturas de Pantalla

| Menú | Juego | Game Over | Volumen |
|------|-------|-----------|---------|
| ![Menú](Images/menu.png) | ![Juego](Images/game.png) | ![Game Over](Images/game_over.png) | ![Volumen](Images/volume.png) |

---

## Video de Jugabilidad

[![Video de Jugabilidad](Images/game.png)](Videos/gameplay.mp4)

> Haz clic en la imagen para ver el video de jugabilidad, o abre `Videos/gameplay.mp4` directamente.

---

## Jugabilidad

- **Toca** en cualquier parte de la pantalla para hacer saltar al patinador
- Evita chocar con los obstáculos y mantente dentro de los límites de la pantalla
- El puntaje aumenta cada vez que pasas por un área de puntuación
- La dificultad escala progresivamente a medida que aumenta tu puntaje:
  - Los obstáculos aparecen más rápido
  - La velocidad de movimiento de los obstáculos aumenta
- Tu **récord** se guarda localmente

> **Nota:** Este juego está diseñado exclusivamente para teléfonos móviles (Android). No está pensado para PC ni tablet.

---

## Características

- Endless runner con dificultad progresiva
- Seguimiento de puntaje con récord persistente (PlayerPrefs)
- Música de fondo y efectos de sonido
- Ajustes de volumen configurables
- Integración con Google AdMob
- Dos escenas: Menú Principal y Juego

---

## Estructura del Proyecto

```
Air-Skater/
├── Assets/
│   ├── CODIGOS/            # Scripts C#
│   │   ├── LogicaPersonaje.cs          # Controlador del personaje (saltar, colisión)
│   │   ├── Controladordeescena.cs      # Controlador de escena (game over, reinicio)
│   │   ├── LogicaGeneradorObtaculos.cs # Generador de obstáculos con escala de dificultad
│   │   ├── LogicaObstaculo.cs          # Movimiento de obstáculos
│   │   ├── LogicaPuntaje.cs            # Visualización del puntaje
│   │   ├── LogicaAreaPuntaje.cs        # Área de detección de puntaje
│   │   ├── PuntajeRecord.cs            # Gestor de récord
│   │   ├── MenuPrincipal.cs            # Navegación del menú
│   │   ├── ControlVolumen.cs           # Control de volumen
│   │   ├── MusicaMenu.cs               # Música del menú
│   │   ├── AdMob.cs                    # Inicialización de AdMob (menú)
│   │   ├── AdMobGame.cs                # Inicialización de AdMob (juego)
│   │   ├── Bloque.cs                   # Comportamiento de bloques
│   │   └── MusicaPerder.cs             # Música de game over
│   ├── Dibujos/            # Assets gráficos (sprites, animaciones, fondos)
│   ├── Prefab/             # Prefabs (obstáculos, UI, música)
│   ├── Scenes/             # Escenas del juego (MENU, JUEGO)
│   ├── Sonidos/            # Archivos de audio (música, SFX)
│   ├── GoogleMobileAds/    # SDK de Google AdMob
│   ├── Plugins/            # Plugins nativos
│   └── TextMesh Pro/       # Paquete TextMeshPro
├── ProjectSettings/        # Configuración del proyecto Unity
├── Packages/               # Manifiesto de paquetes
└── SCREENSHOTS/            # Capturas de pantalla del juego
```

---

## Dependencias

| Paquete | Versión |
|---------|---------|
| 2D Animation | 3.2.5 |
| 2D Pixel Perfect | 2.0.4 |
| 2D PSD Importer | 2.1.6 |
| 2D SpriteShape | 3.0.14 |
| TextMeshPro | 2.1.3 |
| Timeline | 1.2.17 |
| Google Mobile Ads | vía registro scoped |

---

## Configuración

1. Clona el repositorio
2. Abre el proyecto en **Unity 2019.4.14f1** o una versión compatible
3. Deja que Unity importe todos los assets
4. Abre `Assets/Scenes/MENU.unity` para comenzar desde el menú principal
5. Compila para Android desde `File > Build Settings`

---

## Controles

| Acción | Entrada |
|--------|---------|
| Saltar | Toque |
| Navegar Menú | Toque en los botones |
