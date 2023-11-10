# Actividad TRABAJO PRACTICO N°1 DESARROLLO 3D
## Puntos por desarrollar
Esto es un trabajo práctico típico para los que se inician en el desarrollo de videojuegos en Unity
1) Utilizando el Motor Unity 3D, crear un nuevo Proyecto con el nombre practica01
2) Agregar un plano, denominarlo Plane y colocarle un material (crear la carpeta Materials
y colocar allí el material)
3) Agregar un Cubo y colocarle de nombre Player. Agregarle un Material a elección.
Asignarles los componentes e INPUTs necesarios para que este objeto pueda ser
manejado por el jugador. Para este Proyecto se solicita que el movimiento sea solo hacia
los costados. (Izquierda – Derecha -> utilizar Input.getAxis()). Por otro lado la posición
del Player se ubica en la parte inferior del plano.
4) Agregar una Esfera con el nombre BalaPlayer, darle forma de bala, agregarle un
componente que permita el movimiento continuo del objeto hacia adelante (es decir
desde el Player hacia el fondo del plano). Crear el Prefab BalaPlayer y eliminar el objeto
de la escena.
5) Agregar una Esfera con el nombre BalaEnemigo, darle forma de bala, agregarle el mismo
componente usado para BalaPlayer, que permita el movimiento continuo del objeto
hacia adelante (considerar que esto significa que se enfrenta al Player). Crear el Prefab
BalaEnemigo y eliminar el objeto de la escena.
6) Agregar un Cubo con el Nombre Enemigo01. Colocarle un Material a elección. Agregarle
un componente que permita el movimiento del objeto en forma diagonal hacia
adelante. Ese componente debe instanciar el Prefab BalaEnemigo cada cierto intervalo
de tiempo constante. Crear el Prefab Enemigo01 y eliminar el objeto de la escena.
7) Agregar un Cubo con el Nombre Enemigo02. Colocarle un Material a elección. Agregarle
un componente que permita el movimiento del objeto en forma horizontal, en este
caso, cada cierto intervalo de tiempo cambie de dirección (pero que coincida con llegar
a los extremos de los costados del plano). El componente debe permitir instanciar el
Prefab BalaEnemigo cada cierto intervalo de tiempo aleatorio. Crear el Prefab
Enemigo02 y eliminar el objeto de la escena.
8) Agregar un Objeto Vacío con el nombre de Generador01, ubicarlo en una posición
estratégica. Desde este objeto generar Enemig1 cada cierto intervalo de tiempo a
elección.
9) Agregar un Objeto Vacío con el nombre de Generador02, ubicarlo en otra posición
estratégica (al costado izquierdo del plano). Este objeto se mueve de arriba y hacia
abajo y viceversa. Desde este objeto generar Enemigo02 cada cierto intervalo de
tiempo a elección.
10) El Player debe disparar BalaPlayer mediante un input a elección.

## Otras acotaciones:

- Cuando las balas alcancen el limite de distancia del plano deben destruirse

- No usar el sistema de colisiones

- Los movimientos deben estar normalizados en función del tiempo.

- Los Enemigo01, al cruzar el plano son destruidos
## Version Unity: 2022.3.9f1